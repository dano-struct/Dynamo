﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism;

namespace Dynamo.Connectors
{
    public class dynConnectorViewModel
    {
        private dynConnector _connector;

        public dynConnector ConnectorModel
        {
            get { return _connector; }
        }

        public dynConnectorViewModel(dynConnector connector)
        {
            _connector = connector;
            _connector.Connected += _connector_Connected;
        }

        void _connector_Connected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}