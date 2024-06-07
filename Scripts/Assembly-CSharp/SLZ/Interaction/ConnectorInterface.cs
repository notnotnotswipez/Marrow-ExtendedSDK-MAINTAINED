using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	[CreateAssetMenu(fileName = "ConnectorInterface", menuName = "Marrow/ConnectorInterface", order = 1)]
	public class ConnectorInterface : ScriptableObject
	{
		public virtual bool IsCompatibleWith(ConnectorInterface other)
		{
			return false;
		}

		public virtual float Validate(Connector connectorA, Connector connectorB)
		{
			return 0f;
		}

		public virtual SimpleTransform Solve(Connector connectorA, Connector connectorB)
		{
			return default(SimpleTransform);
		}
	}
}
