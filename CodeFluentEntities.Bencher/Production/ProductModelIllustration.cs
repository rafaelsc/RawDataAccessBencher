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
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Illustration.IllustrationID={Illustration.IllustrationID}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class ProductModelIllustration : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Production.ProductModelIllustration>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Production.ProductModelIllustration>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private int _illustrationIllustrationID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.Illustration _illustration = null;
        
        private int _productModelProductModelID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.ProductModel _productModel = null;
        
        public ProductModelIllustration()
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
                object[] keys = new object[] {
                        this.IllustrationIllustrationID,
                        this.ProductModelProductModelID};
                string v = CodeFluentPersistence.BuildEntityKey(keys);
                return v;
            }
            set
            {
                System.Type[] types = new System.Type[] {
                        typeof(int),
                        typeof(int)};
                object[] defaultValues = new object[] {
                        -1,
                        -1};
                object[] v1 = CodeFluentPersistence.ParseEntityKey(value, types, defaultValues);
                this.IllustrationIllustrationID = ((int)(v1[0]));
                this.ProductModelProductModelID = ((int)(v1[1]));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return ((string)(CodeFluent.Runtime.Utilities.ConvertUtilities.Evaluate(this, "Illustration.IllustrationID", typeof(string), null)));
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
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int IllustrationIllustrationID
        {
            get
            {
                if (((this._illustrationIllustrationID == -1) 
                            && (this._illustration != null)))
                {
                    this._illustrationIllustrationID = this._illustration.IllustrationID;
                }
                return this._illustrationIllustrationID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.IllustrationIllustrationID) == true))
                {
                    return;
                }
                this._illustration = null;
                this._illustrationIllustrationID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Illustration"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("IllustrationIllustrationID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.Illustration Illustration
        {
            get
            {
                if ((this._illustration == null))
                {
                    this._illustration = CodeFluentEntities.Bencher.Production.Illustration.Load(this._illustrationIllustrationID);
                }
                return this._illustration;
            }
            set
            {
                this._illustrationIllustrationID = -1;
                this._illustration = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Illustration"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("IllustrationIllustrationID"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ProductModelProductModelID
        {
            get
            {
                if (((this._productModelProductModelID == -1) 
                            && (this._productModel != null)))
                {
                    this._productModelProductModelID = this._productModel.ProductModelID;
                }
                return this._productModelProductModelID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.ProductModelProductModelID) == true))
                {
                    return;
                }
                this._productModel = null;
                this._productModelProductModelID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductModel"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductModelProductModelID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.ProductModel ProductModel
        {
            get
            {
                if ((this._productModel == null))
                {
                    this._productModel = CodeFluentEntities.Bencher.Production.ProductModel.Load(this._productModelProductModelID);
                }
                return this._productModel;
            }
            set
            {
                this._productModelProductModelID = -1;
                this._productModel = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductModel"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductModelProductModelID"));
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
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration)
        {
            if ((productModelIllustration == null))
            {
                return false;
            }
            if (((this.IllustrationIllustrationID == -1) 
                        || (this.ProductModelProductModelID == -1)))
            {
                return base.Equals(productModelIllustration);
            }
            return ((this.IllustrationIllustrationID.Equals(productModelIllustration.IllustrationIllustrationID) && this.ProductModelProductModelID.Equals(productModelIllustration.ProductModelProductModelID)) 
                        == true);
        }
        
        public override int GetHashCode()
        {
            if ((this.EntityKey == null))
            {
                return base.GetHashCode();
            }
            return this.EntityKey.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration = null;
			productModelIllustration = obj as CodeFluentEntities.Bencher.Production.ProductModelIllustration;
            return this.Equals(productModelIllustration);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration = null;
productModelIllustration = value as CodeFluentEntities.Bencher.Production.ProductModelIllustration;
            if ((productModelIllustration == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(productModelIllustration);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration)
        {
            if ((productModelIllustration == null))
            {
                throw new System.ArgumentNullException("productModelIllustration");
            }
            int localCompareTo = this.Illustration.CompareTo(productModelIllustration.Illustration);
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
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Production.ProductModelIllustration.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Production.ProductModelIllustration\' cannot be v" +
                            "alidated.", null);
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
            persistence.CreateStoredProcedureCommand("Production", "ProductModelIllustration", "Delete");
            persistence.AddRawParameter("@IllustrationID", this.IllustrationIllustrationID);
            persistence.AddRawParameter("@ProductModelID", this.ProductModelProductModelID);
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
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.IllustrationIllustrationID = CodeFluentPersistence.GetReaderValue(reader, "IllustrationID", ((int)(-1)));
                this.ProductModelProductModelID = CodeFluentPersistence.GetReaderValue(reader, "ProductModelID", ((int)(-1)));
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
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductModelIllustration Load(int illustrationIllustrationID, int productModelProductModelID)
        {
            if ((illustrationIllustrationID == -1))
            {
                return null;
            }
            if ((productModelProductModelID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration = new CodeFluentEntities.Bencher.Production.ProductModelIllustration();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductModelIllustration", "Load");
            persistence.AddRawParameter("@IllustrationIllustrationID", illustrationIllustrationID);
            persistence.AddRawParameter("@ProductModelProductModelID", productModelProductModelID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    productModelIllustration.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    productModelIllustration.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return productModelIllustration;
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
            if (((this.IllustrationIllustrationID == -1) 
                        || (this.ProductModelProductModelID == -1)))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductModelIllustration", "Load");
            persistence.AddRawParameter("@IllustrationIllustrationID", this.IllustrationIllustrationID);
            persistence.AddRawParameter("@ProductModelProductModelID", this.ProductModelProductModelID);
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
            persistence.CreateStoredProcedureCommand("Production", "ProductModelIllustration", "Save");
            persistence.AddRawParameter("@IllustrationID", this.IllustrationIllustrationID);
            persistence.AddRawParameter("@ProductModelID", this.ProductModelProductModelID);
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
        public static bool Save(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration)
        {
            if ((productModelIllustration == null))
            {
                return false;
            }
            bool ret = productModelIllustration.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration)
        {
            bool ret = CodeFluentEntities.Bencher.Production.ProductModelIllustration.Save(productModelIllustration);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration)
        {
            if ((productModelIllustration == null))
            {
                return false;
            }
            bool ret = productModelIllustration.Delete();
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
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("Illustration=");
            if ((this._illustration != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._illustration)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_illustrationIllustrationID=");
            writer.Write(this._illustrationIllustrationID);
            writer.Write(",");
            writer.Write("ProductModel=");
            if ((this._productModel != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._productModel)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_productModelProductModelID=");
            writer.Write(this._productModelProductModelID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductModelIllustration LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration;
            System.Type[] types = new System.Type[] {
                    typeof(int),
                    typeof(int)};
            object[] defaultValues = new object[] {
                    -1,
                    -1};
            object[] v = CodeFluentPersistence.ParseEntityKey(key, types, defaultValues);
            int var0;
            var0 = ((int)(v[0]));
            int var1;
            var1 = ((int)(v[1]));
            productModelIllustration = CodeFluentEntities.Bencher.Production.ProductModelIllustration.Load(var0, var1);
            return productModelIllustration;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Production.ProductModelIllustration Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration = new CodeFluentEntities.Bencher.Production.ProductModelIllustration();
            this.CopyTo(productModelIllustration, deep);
            return productModelIllustration;
        }
        
        public CodeFluentEntities.Bencher.Production.ProductModelIllustration Clone()
        {
            CodeFluentEntities.Bencher.Production.ProductModelIllustration localClone = this.Clone(true);
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
            if ((dict.Contains("ProductModelProductModelID") == true))
            {
                this.ProductModelProductModelID = ((int)(ConvertUtilities.ChangeType(dict["ProductModelProductModelID"], typeof(int), -1)));
            }
            if ((dict.Contains("IllustrationIllustrationID") == true))
            {
                this.IllustrationIllustrationID = ((int)(ConvertUtilities.ChangeType(dict["IllustrationIllustrationID"], typeof(int), -1)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Production.ProductModelIllustration productModelIllustration, bool deep)
        {
            if ((productModelIllustration == null))
            {
                throw new System.ArgumentNullException("productModelIllustration");
            }
            productModelIllustration.ProductModelProductModelID = this.ProductModelProductModelID;
            productModelIllustration.IllustrationIllustrationID = this.IllustrationIllustrationID;
            productModelIllustration.ModifiedDate = this.ModifiedDate;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, productModelIllustration));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["ProductModelProductModelID"] = this.ProductModelProductModelID;
            dict["IllustrationIllustrationID"] = this.IllustrationIllustrationID;
            dict["ModifiedDate"] = this.ModifiedDate;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
