namespace SharpGPX.Extensions.Garmin.TripExtensions
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1")]
    [System.Xml.Serialization.XmlRootAttribute("TripExtension_t", Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1", IsNullable = false)]
    public partial class TripExtension_t : System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary />
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private string transportationModeField;

        private Extensions_t extensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string TransportationMode
        {
            get
            {
                return this.transportationModeField;
            }
            set
            {
                this.transportationModeField = value;
                this.RaisePropertyChanged("TransportationMode");
            }
        }

        /// <remarks/>
        public Extensions_t Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1")]
    [System.Xml.Serialization.XmlRootAttribute("Extensions_t", Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1", IsNullable = false)]
    public partial class Extensions_t : System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary />
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElement()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return anyField;
            }
            set
            {
                anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1")]
    [System.Xml.Serialization.XmlRootAttribute("ViaPointExtension_t", Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1", IsNullable = false)]
    public partial class ViaPointExtension_t : System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary />
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private System.DateTime departureTimeField;

        private bool departureTimeFieldSpecified;

        private string stopDurationField;

        private System.DateTime arrivalTimeField;

        private bool arrivalTimeFieldSpecified;

        private string calculationModeField;

        private string elevationModeField;

        private NamedRoad_t namedRoadField;

        private Extensions_t extensionsField;

        /// <remarks/>
        public System.DateTime DepartureTime
        {
            get
            {
                return this.departureTimeField;
            }
            set
            {
                this.departureTimeField = value;
                this.RaisePropertyChanged("DepartureTime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureTimeSpecified
        {
            get
            {
                return this.departureTimeFieldSpecified;
            }
            set
            {
                this.departureTimeFieldSpecified = value;
                this.RaisePropertyChanged("DepartureTimeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string StopDuration
        {
            get
            {
                return this.stopDurationField;
            }
            set
            {
                this.stopDurationField = value;
                this.RaisePropertyChanged("StopDuration");
            }
        }

        /// <remarks/>
        public System.DateTime ArrivalTime
        {
            get
            {
                return this.arrivalTimeField;
            }
            set
            {
                this.arrivalTimeField = value;
                this.RaisePropertyChanged("ArrivalTime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalTimeSpecified
        {
            get
            {
                return this.arrivalTimeFieldSpecified;
            }
            set
            {
                this.arrivalTimeFieldSpecified = value;
                this.RaisePropertyChanged("ArrivalTimeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string CalculationMode
        {
            get
            {
                return this.calculationModeField;
            }
            set
            {
                this.calculationModeField = value;
                this.RaisePropertyChanged("CalculationMode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ElevationMode
        {
            get
            {
                return this.elevationModeField;
            }
            set
            {
                this.elevationModeField = value;
                this.RaisePropertyChanged("ElevationMode");
            }
        }

        /// <remarks/>
        public NamedRoad_t NamedRoad
        {
            get
            {
                return this.namedRoadField;
            }
            set
            {
                this.namedRoadField = value;
                this.RaisePropertyChanged("NamedRoad");
            }
        }

        /// <remarks/>
        public Extensions_t Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1")]
    [System.Xml.Serialization.XmlRootAttribute("NamedRoad_t", Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1", IsNullable = false)]
    public partial class NamedRoad_t : System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary />
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private string nameField;

        private int idField;

        private int productIdField;

        private Extensions_t extensionsField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        public int Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        public int ProductId
        {
            get
            {
                return productIdField;
            }
            set
            {
                productIdField = value;
                this.RaisePropertyChanged("ProductId");
            }
        }

        /// <remarks/>
        public Extensions_t Extensions
        {
            get
            {
                return extensionsField;
            }
            set
            {
                extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1")]
    [System.Xml.Serialization.XmlRootAttribute("ShapingPointExtension_t", Namespace = "http://www.garmin.com/xmlschemas/TripExtensions/v1", IsNullable = false)]
    public partial class ShapingPointExtension_t : System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary />
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private Extensions_t extensionsField;

        /// <remarks/>
        public Extensions_t Extensions
        {
            get
            {
                return extensionsField;
            }
            set
            {
                extensionsField = value;
                this.RaisePropertyChanged("Extensions");
            }
        }
    }
}
