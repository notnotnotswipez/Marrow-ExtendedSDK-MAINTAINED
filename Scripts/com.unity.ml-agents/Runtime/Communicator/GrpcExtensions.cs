using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Unity.MLAgents.CommunicatorObjects;
using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Demonstrations;
using Unity.MLAgents.Policies;

using Unity.MLAgents.Analytics;

[assembly: InternalsVisibleTo("Unity.ML-Agents.Editor")]
[assembly: InternalsVisibleTo("Unity.ML-Agents.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.ML-Agents.Runtime.Utils.Tests")]

namespace Unity.MLAgents
{
    internal static class GrpcExtensions
    {
        #region AgentInfo
        /// <summary>
        /// Static flag to make sure that we only fire the warning once.
        /// </summary>
        private static bool s_HaveWarnedTrainerCapabilitiesAgentGroup;

        /// <summary>
        /// Converts a AgentInfo to a protobuf generated AgentInfoActionPairProto
        /// </summary>
        /// <returns>The protobuf version of the AgentInfoActionPairProto.</returns>
        public static AgentInfoActionPairProto ToInfoActionPairProto(this AgentInfo ai)
        {
            return null;
        }

        /// <summary>
        /// Converts a AgentInfo to a protobuf generated AgentInfoProto
        /// </summary>
        /// <returns>The protobuf version of the AgentInfo.</returns>
        public static AgentInfoProto ToAgentInfoProto(this AgentInfo ai)
        {
            return null;
        }

        /// <summary>
        /// Get summaries for the observations in the AgentInfo part of the AgentInfoActionPairProto.
        /// </summary>
        /// <param name="infoActionPair"></param>
        /// <returns></returns>
        public static List<ObservationSummary> GetObservationSummaries(this AgentInfoActionPairProto infoActionPair)
        {
            List<ObservationSummary> summariesOut = new List<ObservationSummary>();
            var agentInfo = infoActionPair.AgentInfo;
            foreach (var obs in agentInfo.Observations)
            {
                var summary = new ObservationSummary();
                summary.shape = obs.Shape.ToArray();
                summariesOut.Add(summary);
            }

            return summariesOut;
        }

        #endregion

        #region BrainParameters
        /// <summary>
        /// Converts a BrainParameters into to a BrainParametersProto so it can be sent.
        /// </summary>
        /// <returns>The BrainInfoProto generated.</returns>
        /// <param name="bp">The instance of BrainParameter to extend.</param>
        /// <param name="name">The name of the brain.</param>
        /// <param name="isTraining">Whether or not the Brain is training.</param>
        public static BrainParametersProto ToProto(this BrainParameters bp, string name, bool isTraining)
        {
            return null;
        }

        /// <summary>
        /// Converts an ActionSpec into to a Protobuf BrainInfoProto so it can be sent.
        /// </summary>
        /// <returns>The BrainInfoProto generated.</returns>
        /// <param name="actionSpec"> Description of the actions for the Agent.</param>
        /// <param name="name">The name of the brain.</param>
        /// <param name="isTraining">Whether or not the Brain is training.</param>
        public static BrainParametersProto ToBrainParametersProto(this ActionSpec actionSpec, string name, bool isTraining)
        {
            return null;
        }

        /// <summary>
        /// Convert a BrainParametersProto to a BrainParameters struct.
        /// </summary>
        /// <param name="bpp">An instance of a brain parameters protobuf object.</param>
        /// <returns>A BrainParameters struct.</returns>
        public static BrainParameters ToBrainParameters(this BrainParametersProto bpp)
        {
            ActionSpec actionSpec;
            if (bpp.ActionSpec == null)
            {
                // Disable deprecation warnings so we can set legacy fields
#pragma warning disable CS0618
                var spaceType = (SpaceType)bpp.VectorActionSpaceTypeDeprecated;
                if (spaceType == SpaceType.Continuous)
                {
                    actionSpec = ActionSpec.MakeContinuous(bpp.VectorActionSizeDeprecated.ToArray()[0]);
                }
                else
                {
                    actionSpec = ActionSpec.MakeDiscrete(bpp.VectorActionSizeDeprecated.ToArray());
                }
#pragma warning restore CS0618
            }
            else
            {
                actionSpec = ToActionSpec(bpp.ActionSpec);
            }
            var bp = new BrainParameters
            {
                VectorActionDescriptions = bpp.VectorActionDescriptionsDeprecated.ToArray(),
                ActionSpec = actionSpec,
            };
            return bp;
        }

        /// <summary>
        /// Convert a ActionSpecProto to a ActionSpec struct.
        /// </summary>
        /// <param name="actionSpecProto">An instance of an action spec protobuf object.</param>
        /// <returns>An ActionSpec struct.</returns>
        public static ActionSpec ToActionSpec(this ActionSpecProto actionSpecProto)
        {
            var actionSpec = new ActionSpec(actionSpecProto.NumContinuousActions);
            if (actionSpecProto.DiscreteBranchSizes != null)
            {
                actionSpec.BranchSizes = actionSpecProto.DiscreteBranchSizes.ToArray();
            }
            return actionSpec;
        }

        /// <summary>
        /// Convert a ActionSpec struct to a ActionSpecProto.
        /// </summary>
        /// <param name="actionSpec">An instance of an action spec struct.</param>
        /// <returns>An ActionSpecProto.</returns>
        public static ActionSpecProto ToActionSpecProto(this ActionSpec actionSpec)
        {
            var actionSpecProto = new ActionSpecProto
            {
                NumContinuousActions = actionSpec.NumContinuousActions,
                NumDiscreteActions = actionSpec.NumDiscreteActions,
            };
            if (actionSpec.BranchSizes != null)
            {
                actionSpecProto.DiscreteBranchSizes.AddRange(actionSpec.BranchSizes);
            }
            return actionSpecProto;
        }

        #endregion

        #region DemonstrationMetaData
        /// <summary>
        /// Convert metadata object to proto object.
        /// </summary>
        public static DemonstrationMetaProto ToProto(this DemonstrationMetaData dm)
        {
            var demonstrationName = dm.demonstrationName ?? "";
            var demoProto = new DemonstrationMetaProto
            {
                ApiVersion = DemonstrationMetaData.ApiVersion,
                MeanReward = dm.meanReward,
                NumberSteps = dm.numberSteps,
                NumberEpisodes = dm.numberEpisodes,
                DemonstrationName = demonstrationName
            };
            return demoProto;
        }

        /// <summary>
        /// Initialize metadata values based on proto object.
        /// </summary>
        public static DemonstrationMetaData ToDemonstrationMetaData(this DemonstrationMetaProto demoProto)
        {
            var dm = new DemonstrationMetaData
            {
                numberEpisodes = demoProto.NumberEpisodes,
                numberSteps = demoProto.NumberSteps,
                meanReward = demoProto.MeanReward,
                demonstrationName = demoProto.DemonstrationName
            };
            if (demoProto.ApiVersion != DemonstrationMetaData.ApiVersion)
            {
                throw new Exception("API versions of demonstration are incompatible.");
            }
            return dm;
        }

        #endregion

        public static UnityRLInitParameters ToUnityRLInitParameters(this UnityRLInitializationInputProto inputProto)
        {
            return new UnityRLInitParameters
            {
                seed = inputProto.Seed,
                numAreas = inputProto.NumAreas,
                pythonLibraryVersion = inputProto.PackageVersion,
                pythonCommunicationVersion = inputProto.CommunicationVersion,
                TrainerCapabilities = inputProto.Capabilities.ToRLCapabilities()
            };
        }

        #region AgentAction
        public static List<ActionBuffers> ToAgentActionList(this UnityRLInputProto.Types.ListAgentActionProto proto)
        {
            var agentActions = new List<ActionBuffers>(proto.Value.Count);
            foreach (var ap in proto.Value)
            {
                agentActions.Add(ap.ToActionBuffers());
            }
            return agentActions;
        }

        public static ActionBuffers ToActionBuffers(this AgentActionProto proto)
        {
            return new ActionBuffers(proto.ContinuousActions.ToArray(), proto.DiscreteActions.ToArray());
        }

        #endregion

        #region Observations
        /// <summary>
        /// Static flag to make sure that we only fire the warning once.
        /// </summary>
        private static bool s_HaveWarnedTrainerCapabilitiesMultiPng;
        private static bool s_HaveWarnedTrainerCapabilitiesMapping;

        /// <summary>
        /// Generate an ObservationProto for the sensor using the provided ObservationWriter.
        /// This is equivalent to producing an Observation and calling Observation.ToProto(),
        /// but avoid some intermediate memory allocations.
        /// </summary>
        /// <param name="sensor"></param>
        /// <param name="observationWriter"></param>
        /// <returns></returns>
        public static ObservationProto GetObservationProto(this ISensor sensor, ObservationWriter observationWriter)
        {
            return null;
        }

        #endregion

        public static UnityRLCapabilities ToRLCapabilities(this UnityRLCapabilitiesProto proto)
        {
            return new UnityRLCapabilities
            {
                BaseRLCapabilities = proto.BaseRLCapabilities,
                ConcatenatedPngObservations = proto.ConcatenatedPngObservations,
                CompressedChannelMapping = proto.CompressedChannelMapping,
                HybridActions = proto.HybridActions,
                TrainingAnalytics = proto.TrainingAnalytics,
                VariableLengthObservation = proto.VariableLengthObservation,
                MultiAgentGroups = proto.MultiAgentGroups,
            };
        }

        public static UnityRLCapabilitiesProto ToProto(this UnityRLCapabilities rlCaps)
        {
            return new UnityRLCapabilitiesProto
            {
                BaseRLCapabilities = rlCaps.BaseRLCapabilities,
                ConcatenatedPngObservations = rlCaps.ConcatenatedPngObservations,
                CompressedChannelMapping = rlCaps.CompressedChannelMapping,
                HybridActions = rlCaps.HybridActions,
                TrainingAnalytics = rlCaps.TrainingAnalytics,
                VariableLengthObservation = rlCaps.VariableLengthObservation,
                MultiAgentGroups = rlCaps.MultiAgentGroups,
            };
        }

        #region Analytics
        internal static TrainingEnvironmentInitializedEvent ToTrainingEnvironmentInitializedEvent(
            this TrainingEnvironmentInitialized inputProto)
        {
            return new TrainingEnvironmentInitializedEvent
            {
                TrainerPythonVersion = inputProto.PythonVersion,
                MLAgentsVersion = inputProto.MlagentsVersion,
                MLAgentsEnvsVersion = inputProto.MlagentsEnvsVersion,
                TorchVersion = inputProto.TorchVersion,
                TorchDeviceType = inputProto.TorchDeviceType,
                NumEnvironments = inputProto.NumEnvs,
                NumEnvironmentParameters = inputProto.NumEnvironmentParameters,
                RunOptions = inputProto.RunOptions,
            };
        }

        internal static TrainingBehaviorInitializedEvent ToTrainingBehaviorInitializedEvent(
            this TrainingBehaviorInitialized inputProto)
        {
            RewardSignals rewardSignals = 0;
            rewardSignals |= inputProto.ExtrinsicRewardEnabled ? RewardSignals.Extrinsic : 0;
            rewardSignals |= inputProto.GailRewardEnabled ? RewardSignals.Gail : 0;
            rewardSignals |= inputProto.CuriosityRewardEnabled ? RewardSignals.Curiosity : 0;
            rewardSignals |= inputProto.RndRewardEnabled ? RewardSignals.Rnd : 0;

            TrainingFeatures trainingFeatures = 0;
            trainingFeatures |= inputProto.BehavioralCloningEnabled ? TrainingFeatures.BehavioralCloning : 0;
            trainingFeatures |= inputProto.RecurrentEnabled ? TrainingFeatures.Recurrent : 0;
            trainingFeatures |= inputProto.TrainerThreaded ? TrainingFeatures.Threaded : 0;
            trainingFeatures |= inputProto.SelfPlayEnabled ? TrainingFeatures.SelfPlay : 0;
            trainingFeatures |= inputProto.CurriculumEnabled ? TrainingFeatures.Curriculum : 0;


            return new TrainingBehaviorInitializedEvent
            {
                BehaviorName = inputProto.BehaviorName,
                TrainerType = inputProto.TrainerType,
                RewardSignalFlags = rewardSignals,
                TrainingFeatureFlags = trainingFeatures,
                VisualEncoder = inputProto.VisualEncoder,
                NumNetworkLayers = inputProto.NumNetworkLayers,
                NumNetworkHiddenUnits = inputProto.NumNetworkHiddenUnits,
                Config = inputProto.Config,
            };
        }

        #endregion
    }
}
