﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductModel'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductModel : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductModel"/> class.</summary>
		public ProductModel() : base()
		{
			this.Products = new HashSet<Product>();
			this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
			this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CatalogDescription field. </summary>
		[DataMember]
		public System.String CatalogDescription { get; set;}
		/// <summary>Gets or sets the Instructions field. </summary>
		[DataMember]
		public System.String Instructions { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Gets or sets the ProductModelId field. </summary>
		[DataMember]
		public System.Int32 ProductModelId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.ProductModel - ProductModel.Products (m:1)'</summary>
		[DataMember]
		public virtual ICollection<Product> Products { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelIllustration.ProductModel - ProductModel.ProductModelIllustrations (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.ProductModel - ProductModel.ProductModelProductDescriptionCultures (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set;}
		#endregion
	}
}