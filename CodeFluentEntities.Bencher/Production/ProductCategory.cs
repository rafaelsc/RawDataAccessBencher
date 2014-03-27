﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Production
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Name={Name}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class ProductCategory : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Production.ProductCategory>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Production.ProductCategory>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _productCategoryID = -1;
        
        private string _name = default(string);
        
        private System.Guid _rowguid = CodeFluentPersistence.DefaultGuidValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.ProductSubcategoryCollection _productSubcategories;
        
        public ProductCategory()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.ProductCategoryID.ToString();
            }
            set
            {
                this.ProductCategoryID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.Name;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ProductCategoryID
        {
            get
            {
                return this._productCategoryID;
            }
            set
            {
                this._productCategoryID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductCategoryID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Name"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        public System.Guid Rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Rowguid"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.ProductSubcategoryCollection ProductSubcategories
        {
            get
            {
                if ((this._productSubcategories == null))
                {
                    if (((this.ProductCategoryID == -1) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._productSubcategories = new CodeFluentEntities.Bencher.Production.ProductSubcategoryCollection(this);
                        return this._productSubcategories;
                    }
                    this._productSubcategories = CodeFluentEntities.Bencher.Production.ProductSubcategoryCollection.LoadByProductCategory(this);
                }
                return this._productSubcategories;
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Production.ProductCategory productCategory)
        {
            if ((productCategory == null))
            {
                return false;
            }
            if ((this.ProductCategoryID == -1))
            {
                return base.Equals(productCategory);
            }
            return (this.ProductCategoryID.Equals(productCategory.ProductCategoryID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._productCategoryID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Production.ProductCategory productCategory = null;
			productCategory = obj as CodeFluentEntities.Bencher.Production.ProductCategory;
            return this.Equals(productCategory);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductCategory productCategory = null;
productCategory = value as CodeFluentEntities.Bencher.Production.ProductCategory;
            if ((productCategory == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(productCategory);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Production.ProductCategory productCategory)
        {
            if ((productCategory == null))
            {
                throw new System.ArgumentNullException("productCategory");
            }
            int localCompareTo = this.ProductCategoryID.CompareTo(productCategory.ProductCategoryID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Production.ProductCategory.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Production.ProductCategory\' cannot be validated." +
                            "", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductCategory", "Delete");
            persistence.AddRawParameter("@ProductCategoryID", this.ProductCategoryID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._productCategoryID = CodeFluentPersistence.GetReaderValue(reader, "ProductCategoryID", ((int)(-1)));
                this._name = CodeFluentPersistence.GetReaderValue(reader, "Name", ((string)(default(string))));
                this._rowguid = CodeFluentPersistence.GetReaderValue(reader, "rowguid", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._productCategoryID = CodeFluentPersistence.GetReaderValue(reader, "ProductCategoryID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductCategory Load(int productCategoryID)
        {
            if ((productCategoryID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.ProductCategory productCategory = new CodeFluentEntities.Bencher.Production.ProductCategory();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductCategory", "Load");
            persistence.AddRawParameter("@ProductCategoryID", productCategoryID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    productCategory.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    productCategory.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return productCategory;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.ProductCategoryID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductCategory", "Load");
            persistence.AddRawParameter("@ProductCategoryID", this.ProductCategoryID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductCategory", "Save");
            persistence.AddRawParameter("@ProductCategoryID", this.ProductCategoryID);
            persistence.AddRawParameter("@Name", this.Name);
            persistence.AddRawParameter("@rowguid", this.Rowguid);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Production.ProductCategory productCategory)
        {
            if ((productCategory == null))
            {
                return false;
            }
            bool ret = productCategory.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Production.ProductCategory productCategory)
        {
            bool ret = CodeFluentEntities.Bencher.Production.ProductCategory.Save(productCategory);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Production.ProductCategory productCategory)
        {
            if ((productCategory == null))
            {
                return false;
            }
            bool ret = productCategory.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("ProductCategoryID=");
            writer.Write(this.ProductCategoryID);
            writer.Write(",");
            writer.Write("Name=");
            writer.Write(this.Name);
            writer.Write(",");
            writer.Write("Rowguid=");
            writer.Write(this.Rowguid);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("ProductSubcategories=");
            if ((this._productSubcategories != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._productSubcategories)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductCategory LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.ProductCategory productCategory;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            productCategory = CodeFluentEntities.Bencher.Production.ProductCategory.Load(var);
            return productCategory;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Production.ProductCategory Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Production.ProductCategory productCategory = new CodeFluentEntities.Bencher.Production.ProductCategory();
            this.CopyTo(productCategory, deep);
            return productCategory;
        }
        
        public CodeFluentEntities.Bencher.Production.ProductCategory Clone()
        {
            CodeFluentEntities.Bencher.Production.ProductCategory localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("ProductCategoryID") == true))
            {
                this.ProductCategoryID = ((int)(ConvertUtilities.ChangeType(dict["ProductCategoryID"], typeof(int), -1)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("Rowguid") == true))
            {
                this.Rowguid = ((System.Guid)(ConvertUtilities.ChangeType(dict["Rowguid"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("Name") == true))
            {
                this.Name = ((string)(ConvertUtilities.ChangeType(dict["Name"], typeof(string), default(string))));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Production.ProductCategory productCategory, bool deep)
        {
            if ((productCategory == null))
            {
                throw new System.ArgumentNullException("productCategory");
            }
            productCategory.ProductCategoryID = this.ProductCategoryID;
            productCategory.ModifiedDate = this.ModifiedDate;
            productCategory.Rowguid = this.Rowguid;
            productCategory.Name = this.Name;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, productCategory));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["ProductCategoryID"] = this.ProductCategoryID;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["Rowguid"] = this.Rowguid;
            dict["Name"] = this.Name;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
