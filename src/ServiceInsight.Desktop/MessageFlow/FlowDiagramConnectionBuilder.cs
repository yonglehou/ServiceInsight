﻿namespace Particular.ServiceInsight.Desktop.MessageFlow
{
    using Mindscape.WpfDiagramming.Foundation;

    public class FlowDiagramConnectionBuilder : IDiagramConnectionBuilder
    {
        public bool CanCreateConnection(IDiagramModel diagram, IDiagramConnectionPoint fromConnectionPoint, ConnectionDropTarget dropTarget)
        {
            return false;
        }

        public void CreateConnection(IDiagramModel diagram, IDiagramConnectionPoint fromConnectionPoint, IDiagramConnectionPoint toConnectionPoint)
        {
        }
    }
}