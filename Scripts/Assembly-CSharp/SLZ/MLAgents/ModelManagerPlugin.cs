using System.Threading;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;

namespace SLZ.MLAgents
{
	[MarrowPlugin("MLPlugins", "ModelManagerPlugin", "0.0.1")]
	public class ModelManagerPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		public ModelManagerConfig config;

		public BarracudaModelManager_OLD ModelManagerOld;

		private CancellationTokenSource disableCancellation;

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginRunCallbacks_002EOnMarrowPluginStop()
		{
			return default(UniTask);
		}

		public void ModelManagerRun()
		{
		}

		public void ModelManagerStop()
		{
		}
	}
}
