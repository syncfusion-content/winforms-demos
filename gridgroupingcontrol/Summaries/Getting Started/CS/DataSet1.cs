﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace SummaryTutorial {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet1 : DataSet {
        
        private StatisticsDataTable tableStatistics;
        
        public DataSet1() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DataSet1(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Statistics"] != null)) {
                    this.Tables.Add(new StatisticsDataTable(ds.Tables["Statistics"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public StatisticsDataTable Statistics {
            get {
                return this.tableStatistics;
            }
        }
        
        public override DataSet Clone() {
            DataSet1 cln = ((DataSet1)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Statistics"] != null)) {
                this.Tables.Add(new StatisticsDataTable(ds.Tables["Statistics"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableStatistics = ((StatisticsDataTable)(this.Tables["Statistics"]));
            if ((this.tableStatistics != null)) {
                this.tableStatistics.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DataSet1";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableStatistics = new StatisticsDataTable();
            this.Tables.Add(this.tableStatistics);
        }
        
        private bool ShouldSerializeStatistics() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void StatisticsRowChangeEventHandler(object sender, StatisticsRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class StatisticsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnID;
            
            private DataColumn columnlosses;
            
            private DataColumn columnSchool;
            
            private DataColumn columnSport;
            
            private DataColumn columnties;
            
            private DataColumn columnwins;
            
            private DataColumn columnyear;
            
            internal StatisticsDataTable() : 
                    base("Statistics") {
                this.InitClass();
            }
            
            internal StatisticsDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            internal DataColumn lossesColumn {
                get {
                    return this.columnlosses;
                }
            }
            
            internal DataColumn SchoolColumn {
                get {
                    return this.columnSchool;
                }
            }
            
            internal DataColumn SportColumn {
                get {
                    return this.columnSport;
                }
            }
            
            internal DataColumn tiesColumn {
                get {
                    return this.columnties;
                }
            }
            
            internal DataColumn winsColumn {
                get {
                    return this.columnwins;
                }
            }
            
            internal DataColumn yearColumn {
                get {
                    return this.columnyear;
                }
            }
            
            public StatisticsRow this[int index] {
                get {
                    return ((StatisticsRow)(this.Rows[index]));
                }
            }
            
            public event StatisticsRowChangeEventHandler StatisticsRowChanged;
            
            public event StatisticsRowChangeEventHandler StatisticsRowChanging;
            
            public event StatisticsRowChangeEventHandler StatisticsRowDeleted;
            
            public event StatisticsRowChangeEventHandler StatisticsRowDeleting;
            
            public void AddStatisticsRow(StatisticsRow row) {
                this.Rows.Add(row);
            }
            
            public StatisticsRow AddStatisticsRow(int losses, string School, string Sport, int ties, int wins, int year) {
                StatisticsRow rowStatisticsRow = ((StatisticsRow)(this.NewRow()));
                rowStatisticsRow.ItemArray = new object[] {
                        null,
                        losses,
                        School,
                        Sport,
                        ties,
                        wins,
                        year};
                this.Rows.Add(rowStatisticsRow);
                return rowStatisticsRow;
            }
            
            public StatisticsRow FindByID(int ID) {
                return ((StatisticsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                StatisticsDataTable cln = ((StatisticsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new StatisticsDataTable();
            }
            
            internal void InitVars() {
                this.columnID = this.Columns["ID"];
                this.columnlosses = this.Columns["losses"];
                this.columnSchool = this.Columns["School"];
                this.columnSport = this.Columns["Sport"];
                this.columnties = this.Columns["ties"];
                this.columnwins = this.Columns["wins"];
                this.columnyear = this.Columns["year"];
            }
            
            private void InitClass() {
                this.columnID = new DataColumn("ID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnID);
                this.columnlosses = new DataColumn("losses", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnlosses);
                this.columnSchool = new DataColumn("School", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSchool);
                this.columnSport = new DataColumn("Sport", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSport);
                this.columnties = new DataColumn("ties", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnties);
                this.columnwins = new DataColumn("wins", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnwins);
                this.columnyear = new DataColumn("year", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnyear);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            public StatisticsRow NewStatisticsRow() {
                return ((StatisticsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new StatisticsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(StatisticsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.StatisticsRowChanged != null)) {
                    this.StatisticsRowChanged(this, new StatisticsRowChangeEvent(((StatisticsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.StatisticsRowChanging != null)) {
                    this.StatisticsRowChanging(this, new StatisticsRowChangeEvent(((StatisticsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.StatisticsRowDeleted != null)) {
                    this.StatisticsRowDeleted(this, new StatisticsRowChangeEvent(((StatisticsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.StatisticsRowDeleting != null)) {
                    this.StatisticsRowDeleting(this, new StatisticsRowChangeEvent(((StatisticsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveStatisticsRow(StatisticsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class StatisticsRow : DataRow {
            
            private StatisticsDataTable tableStatistics;
            
            internal StatisticsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableStatistics = ((StatisticsDataTable)(this.Table));
            }
            
            public int ID {
                get {
                    return ((int)(this[this.tableStatistics.IDColumn]));
                }
                set {
                    this[this.tableStatistics.IDColumn] = value;
                }
            }
            
            public int losses {
                get {
                    try {
                        return ((int)(this[this.tableStatistics.lossesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.lossesColumn] = value;
                }
            }
            
            public string School {
                get {
                    try {
                        return ((string)(this[this.tableStatistics.SchoolColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.SchoolColumn] = value;
                }
            }
            
            public string Sport {
                get {
                    try {
                        return ((string)(this[this.tableStatistics.SportColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.SportColumn] = value;
                }
            }
            
            public int ties {
                get {
                    try {
                        return ((int)(this[this.tableStatistics.tiesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.tiesColumn] = value;
                }
            }
            
            public int wins {
                get {
                    try {
                        return ((int)(this[this.tableStatistics.winsColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.winsColumn] = value;
                }
            }
            
            public int year {
                get {
                    try {
                        return ((int)(this[this.tableStatistics.yearColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableStatistics.yearColumn] = value;
                }
            }
            
            public bool IslossesNull() {
                return this.IsNull(this.tableStatistics.lossesColumn);
            }
            
            public void SetlossesNull() {
                this[this.tableStatistics.lossesColumn] = System.Convert.DBNull;
            }
            
            public bool IsSchoolNull() {
                return this.IsNull(this.tableStatistics.SchoolColumn);
            }
            
            public void SetSchoolNull() {
                this[this.tableStatistics.SchoolColumn] = System.Convert.DBNull;
            }
            
            public bool IsSportNull() {
                return this.IsNull(this.tableStatistics.SportColumn);
            }
            
            public void SetSportNull() {
                this[this.tableStatistics.SportColumn] = System.Convert.DBNull;
            }
            
            public bool IstiesNull() {
                return this.IsNull(this.tableStatistics.tiesColumn);
            }
            
            public void SettiesNull() {
                this[this.tableStatistics.tiesColumn] = System.Convert.DBNull;
            }
            
            public bool IswinsNull() {
                return this.IsNull(this.tableStatistics.winsColumn);
            }
            
            public void SetwinsNull() {
                this[this.tableStatistics.winsColumn] = System.Convert.DBNull;
            }
            
            public bool IsyearNull() {
                return this.IsNull(this.tableStatistics.yearColumn);
            }
            
            public void SetyearNull() {
                this[this.tableStatistics.yearColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class StatisticsRowChangeEvent : EventArgs {
            
            private StatisticsRow eventRow;
            
            private DataRowAction eventAction;
            
            public StatisticsRowChangeEvent(StatisticsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public StatisticsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
