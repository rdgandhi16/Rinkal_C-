﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 29-Jan-16 8:59:41 AM
namespace db_28decModel
{
    
    /// <summary>
    /// There are no comments for db_28decEntities in the schema.
    /// </summary>
    public partial class db_28decEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new db_28decEntities object using the connection string found in the 'db_28decEntities' section of the application configuration file.
        /// </summary>
        public db_28decEntities() : 
                base("name=db_28decEntities", "db_28decEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new db_28decEntities object.
        /// </summary>
        public db_28decEntities(string connectionString) : 
                base(connectionString, "db_28decEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new db_28decEntities object.
        /// </summary>
        public db_28decEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "db_28decEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for tbl_reg in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<tbl_reg> tbl_reg
        {
            get
            {
                if ((this._tbl_reg == null))
                {
                    this._tbl_reg = base.CreateQuery<tbl_reg>("[tbl_reg]");
                }
                return this._tbl_reg;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<tbl_reg> _tbl_reg;
        /// <summary>
        /// There are no comments for tbl_reg in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddTotbl_reg(tbl_reg tbl_reg)
        {
            base.AddObject("tbl_reg", tbl_reg);
        }
    }
    /// <summary>
    /// There are no comments for db_28decModel.tbl_reg in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="db_28decModel", Name="tbl_reg")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class tbl_reg : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new tbl_reg object.
        /// </summary>
        /// <param name="id">Initial value of id.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static tbl_reg Createtbl_reg(int id)
        {
            tbl_reg tbl_reg = new tbl_reg();
            tbl_reg.id = id;
            return tbl_reg;
        }
        /// <summary>
        /// There are no comments for property id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this.ReportPropertyChanging("id");
                this._id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("id");
                this.OnidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _id;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for property fname in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string fname
        {
            get
            {
                return this._fname;
            }
            set
            {
                this.OnfnameChanging(value);
                this.ReportPropertyChanging("fname");
                this._fname = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("fname");
                this.OnfnameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _fname;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnfnameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnfnameChanged();
        /// <summary>
        /// There are no comments for property lname in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string lname
        {
            get
            {
                return this._lname;
            }
            set
            {
                this.OnlnameChanging(value);
                this.ReportPropertyChanging("lname");
                this._lname = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("lname");
                this.OnlnameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _lname;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnlnameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnlnameChanged();
    }
}