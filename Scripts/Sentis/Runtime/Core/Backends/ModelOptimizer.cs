using System;
using System.Linq;
using System.Runtime.CompilerServices; // ToArray(), ToDictionary()
using Unity.Sentis.Compiler.Passes;
using Unity.Sentis.Compiler.Passes.Cleanup;
using Unity.Sentis.Compiler.Passes.Optimization;

[assembly: InternalsVisibleTo("Unity.Sentis.ONNX")]
[assembly: InternalsVisibleTo("Unity.Sentis.Editor")]

namespace Unity.Sentis
{

static class ModelOptimizer
{
    static void RunPasses(Model model, IModelPass[] passes)
    {
        foreach (var pass in passes)
        {
            try
            {
                pass.Run(ref model);
            }
            catch (Exception e)
            {
                model.Warnings.Add(new Model.ImporterWarning($"Optimization Error: {pass.GetType().Name}", Model.WarningType.Error, e.Message));
                Debug.LogError(model.Warnings.Last().Message);
            }
        }
    }

    internal static void OptimizeModel(Model model)
    {
        var optimizationPasses = new IModelPass[]
        {
            new EinsumToMatMulPass(),
            new FuseConstantsPass(),
            new RemoveNoOpsPass(),
            new RemoveUnusedPass(),
            new ConcatenateTransposesPass(),
            new ContractToSimplerLayerPass(),
            new SimplifyReshapeInputPass(),
            new FuseDensePass(),
            new FuseLinearLayersPass(),
            new FuseActivationPass(),
            new ContractSubExpressionPass(),
            new FuseScalarMadPass(),
            new RemoveDuplicatesPass(),
            new RemoveNoOpsPass(),
            // // Good to do those passes at the very end
            new RemoveUnusedPass(),
            new RoundDenormalWeightsPass(),
        };

        RunPasses(model, optimizationPasses);
    }

    internal static void RunCPUFallbackPass(Model model)
    {
        var optimizationPasses = new IModelPass[]
        {
            new CPUFallbackPass(),
        };

        RunPasses(model, optimizationPasses);
    }
}

} // namespace Unity.Sentis
