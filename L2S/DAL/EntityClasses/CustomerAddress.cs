﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CustomerAddress', mapped on table 'AdventureWorks.Sales.CustomerAddress'.</summary>
	[Table(Name="[Sales].[CustomerAddress]")]
	public partial class CustomerAddress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_addressId;
		private System.Int32	_addressTypeId;
		private System.Int32	_customerId;
		private System.DateTime	_modifiedDate;
		private System.Guid	_rowguid;
		private EntityRef <Address> _address;
		private EntityRef <AddressType> _addressType;
		private EntityRef <Customer> _customer;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAddressIdChanging(System.Int32 value);
		partial void OnAddressIdChanged();
		partial void OnAddressTypeIdChanging(System.Int32 value);
		partial void OnAddressTypeIdChanged();
		partial void OnCustomerIdChanging(System.Int32 value);
		partial void OnCustomerIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CustomerAddress"/> class.</summary>
		public CustomerAddress()
		{
			_address = default(EntityRef<Address>);
			_addressType = default(EntityRef<AddressType>);
			_customer = default(EntityRef<Customer>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AddressId field. Mapped on target field 'AddressID'. </summary>
		[Column(Name="AddressID", Storage="_addressId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 AddressId
		{
			get	{ return _addressId; }
			set
			{
				if((_addressId != value))
				{
					if(_address.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnAddressIdChanging(value);
					SendPropertyChanging("AddressId");
					_addressId = value;
					SendPropertyChanged("AddressId");
					OnAddressIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the AddressTypeId field. Mapped on target field 'AddressTypeID'. </summary>
		[Column(Name="AddressTypeID", Storage="_addressTypeId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 AddressTypeId
		{
			get	{ return _addressTypeId; }
			set
			{
				if((_addressTypeId != value))
				{
					if(_addressType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnAddressTypeIdChanging(value);
					SendPropertyChanging("AddressTypeId");
					_addressTypeId = value;
					SendPropertyChanged("AddressTypeId");
					OnAddressTypeIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the CustomerId field. Mapped on target field 'CustomerID'. </summary>
		[Column(Name="CustomerID", Storage="_customerId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 CustomerId
		{
			get	{ return _customerId; }
			set
			{
				if((_customerId != value))
				{
					if(_customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCustomerIdChanging(value);
					SendPropertyChanging("CustomerId");
					_customerId = value;
					SendPropertyChanged("CustomerId");
					OnCustomerIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		[Column(Name="rowguid", Storage="_rowguid", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="uniqueidentifier NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.Address - Address.CustomerAddresses (m:1)'</summary>
		[Association(Name="CustomerAddress_Addressaa2cda66a08a4dd79c546c1833605c8e", Storage="_address", ThisKey="AddressId", IsForeignKey=true)] 
		public Address Address
		{
			get { return _address.Entity; }
			set
			{
				Address previousValue = _address.Entity;
				if((previousValue != value) || (_address.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Address");
					if(previousValue != null)
					{
						_address.Entity = null;
						previousValue.CustomerAddresses.Remove(this);
					}
					_address.Entity = value;
					if(value == null)
					{
						_addressId = default(System.Int32);
					}
					else
					{
						value.CustomerAddresses.Add(this);
						_addressId = value.AddressId;
					}
					this.SendPropertyChanged("Address");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.AddressType - AddressType.CustomerAddresses (m:1)'</summary>
		[Association(Name="CustomerAddress_AddressTyped15bff5c97da4943bfdcbb7825f58f3e", Storage="_addressType", ThisKey="AddressTypeId", IsForeignKey=true)] 
		public AddressType AddressType
		{
			get { return _addressType.Entity; }
			set
			{
				AddressType previousValue = _addressType.Entity;
				if((previousValue != value) || (_addressType.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("AddressType");
					if(previousValue != null)
					{
						_addressType.Entity = null;
						previousValue.CustomerAddresses.Remove(this);
					}
					_addressType.Entity = value;
					if(value == null)
					{
						_addressTypeId = default(System.Int32);
					}
					else
					{
						value.CustomerAddresses.Add(this);
						_addressTypeId = value.AddressTypeId;
					}
					this.SendPropertyChanged("AddressType");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.Customer - Customer.CustomerAddresses (m:1)'</summary>
		[Association(Name="CustomerAddress_Customer6e9120bff1a348dbb20f4e4b722993df", Storage="_customer", ThisKey="CustomerId", IsForeignKey=true)] 
		public Customer Customer
		{
			get { return _customer.Entity; }
			set
			{
				Customer previousValue = _customer.Entity;
				if((previousValue != value) || (_customer.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Customer");
					if(previousValue != null)
					{
						_customer.Entity = null;
						previousValue.CustomerAddresses.Remove(this);
					}
					_customer.Entity = value;
					if(value == null)
					{
						_customerId = default(System.Int32);
					}
					else
					{
						value.CustomerAddresses.Add(this);
						_customerId = value.CustomerId;
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649