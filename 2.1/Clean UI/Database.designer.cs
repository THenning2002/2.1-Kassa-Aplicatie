﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clean_UI
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="p1")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertitemperorder(itemperorder instance);
    partial void Updateitemperorder(itemperorder instance);
    partial void Deleteitemperorder(itemperorder instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    partial void Insertproducttype(producttype instance);
    partial void Updateproducttype(producttype instance);
    partial void Deleteproducttype(producttype instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::Clean_UI.Properties.Settings.Default.p1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<itemperorder> itemperorders
		{
			get
			{
				return this.GetTable<itemperorder>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
		
		public System.Data.Linq.Table<producttype> producttypes
		{
			get
			{
				return this.GetTable<producttype>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customerID;
		
		private string _firstname;
		
		private string _lastname;
		
		private string _city;
		
		private string _phonenumber;
		
		private string _email;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncustomerIDChanging(int value);
    partial void OncustomerIDChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnphonenumberChanging(string value);
    partial void OnphonenumberChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public customer()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int customerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((this._customerID != value))
				{
					this.OncustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("customerID");
					this.OncustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="VarChar(50)")]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(50)")]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phonenumber", DbType="VarChar(50)")]
		public string phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if ((this._phonenumber != value))
				{
					this.OnphonenumberChanging(value);
					this.SendPropertyChanging();
					this._phonenumber = value;
					this.SendPropertyChanged("phonenumber");
					this.OnphonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_order", Storage="_orders", ThisKey="customerID", OtherKey="costumerID")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.itemperorder")]
	public partial class itemperorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemperOrderID;
		
		private System.Nullable<int> _amount;
		
		private System.Nullable<int> _orderID;
		
		private System.Nullable<int> _productID;
		
		private EntityRef<order> _order;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemperOrderIDChanging(int value);
    partial void OnItemperOrderIDChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    partial void OnorderIDChanging(System.Nullable<int> value);
    partial void OnorderIDChanged();
    partial void OnproductIDChanging(System.Nullable<int> value);
    partial void OnproductIDChanged();
    #endregion
		
		public itemperorder()
		{
			this._order = default(EntityRef<order>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemperOrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemperOrderID
		{
			get
			{
				return this._ItemperOrderID;
			}
			set
			{
				if ((this._ItemperOrderID != value))
				{
					this.OnItemperOrderIDChanging(value);
					this.SendPropertyChanging();
					this._ItemperOrderID = value;
					this.SendPropertyChanged("ItemperOrderID");
					this.OnItemperOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderID", DbType="Int")]
		public System.Nullable<int> orderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((this._orderID != value))
				{
					if (this._order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("orderID");
					this.OnorderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="Int")]
		public System.Nullable<int> productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_itemperorder", Storage="_order", ThisKey="orderID", OtherKey="orderID", IsForeignKey=true)]
		public order order
		{
			get
			{
				return this._order.Entity;
			}
			set
			{
				order previousValue = this._order.Entity;
				if (((previousValue != value) 
							|| (this._order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._order.Entity = null;
						previousValue.itemperorders.Remove(this);
					}
					this._order.Entity = value;
					if ((value != null))
					{
						value.itemperorders.Add(this);
						this._orderID = value.orderID;
					}
					else
					{
						this._orderID = default(Nullable<int>);
					}
					this.SendPropertyChanged("order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_itemperorder", Storage="_product", ThisKey="productID", OtherKey="productID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.itemperorders.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.itemperorders.Add(this);
						this._productID = value.productID;
					}
					else
					{
						this._productID = default(Nullable<int>);
					}
					this.SendPropertyChanged("product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderID;
		
		private System.Nullable<System.DateTime> _date;
		
		private int _costumerID;
		
		private EntitySet<itemperorder> _itemperorders;
		
		private EntityRef<customer> _customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderIDChanging(int value);
    partial void OnorderIDChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void OncostumerIDChanging(int value);
    partial void OncostumerIDChanged();
    #endregion
		
		public order()
		{
			this._itemperorders = new EntitySet<itemperorder>(new Action<itemperorder>(this.attach_itemperorders), new Action<itemperorder>(this.detach_itemperorders));
			this._customer = default(EntityRef<customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int orderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((this._orderID != value))
				{
					this.OnorderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("orderID");
					this.OnorderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_costumerID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int costumerID
		{
			get
			{
				return this._costumerID;
			}
			set
			{
				if ((this._costumerID != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncostumerIDChanging(value);
					this.SendPropertyChanging();
					this._costumerID = value;
					this.SendPropertyChanged("costumerID");
					this.OncostumerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_itemperorder", Storage="_itemperorders", ThisKey="orderID", OtherKey="orderID")]
		public EntitySet<itemperorder> itemperorders
		{
			get
			{
				return this._itemperorders;
			}
			set
			{
				this._itemperorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_order", Storage="_customer", ThisKey="costumerID", OtherKey="customerID", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._costumerID = value.customerID;
					}
					else
					{
						this._costumerID = default(int);
					}
					this.SendPropertyChanged("customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_itemperorders(itemperorder entity)
		{
			this.SendPropertyChanging();
			entity.order = this;
		}
		
		private void detach_itemperorders(itemperorder entity)
		{
			this.SendPropertyChanging();
			entity.order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _productID;
		
		private string _productName;
		
		private int _producttypeID;
		
		private System.Nullable<double> _prijs;
		
		private EntitySet<itemperorder> _itemperorders;
		
		private EntityRef<producttype> _producttype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductIDChanging(int value);
    partial void OnproductIDChanged();
    partial void OnproductNameChanging(string value);
    partial void OnproductNameChanged();
    partial void OnproducttypeIDChanging(int value);
    partial void OnproducttypeIDChanged();
    partial void OnprijsChanging(System.Nullable<double> value);
    partial void OnprijsChanged();
    #endregion
		
		public product()
		{
			this._itemperorders = new EntitySet<itemperorder>(new Action<itemperorder>(this.attach_itemperorders), new Action<itemperorder>(this.detach_itemperorders));
			this._producttype = default(EntityRef<producttype>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", DbType="VarChar(50)")]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this.OnproductNameChanging(value);
					this.SendPropertyChanging();
					this._productName = value;
					this.SendPropertyChanged("productName");
					this.OnproductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producttypeID", DbType="Int NOT NULL")]
		public int producttypeID
		{
			get
			{
				return this._producttypeID;
			}
			set
			{
				if ((this._producttypeID != value))
				{
					if (this._producttype.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproducttypeIDChanging(value);
					this.SendPropertyChanging();
					this._producttypeID = value;
					this.SendPropertyChanged("producttypeID");
					this.OnproducttypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prijs", DbType="Float")]
		public System.Nullable<double> prijs
		{
			get
			{
				return this._prijs;
			}
			set
			{
				if ((this._prijs != value))
				{
					this.OnprijsChanging(value);
					this.SendPropertyChanging();
					this._prijs = value;
					this.SendPropertyChanged("prijs");
					this.OnprijsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_itemperorder", Storage="_itemperorders", ThisKey="productID", OtherKey="productID")]
		public EntitySet<itemperorder> itemperorders
		{
			get
			{
				return this._itemperorders;
			}
			set
			{
				this._itemperorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttype_product", Storage="_producttype", ThisKey="producttypeID", OtherKey="producttypeID", IsForeignKey=true)]
		public producttype producttype
		{
			get
			{
				return this._producttype.Entity;
			}
			set
			{
				producttype previousValue = this._producttype.Entity;
				if (((previousValue != value) 
							|| (this._producttype.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._producttype.Entity = null;
						previousValue.products.Remove(this);
					}
					this._producttype.Entity = value;
					if ((value != null))
					{
						value.products.Add(this);
						this._producttypeID = value.producttypeID;
					}
					else
					{
						this._producttypeID = default(int);
					}
					this.SendPropertyChanged("producttype");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_itemperorders(itemperorder entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_itemperorders(itemperorder entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.producttypes")]
	public partial class producttype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _producttypeID;
		
		private string _producttypeomschrijving;
		
		private EntitySet<product> _products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproducttypeIDChanging(int value);
    partial void OnproducttypeIDChanged();
    partial void OnproducttypeomschrijvingChanging(string value);
    partial void OnproducttypeomschrijvingChanged();
    #endregion
		
		public producttype()
		{
			this._products = new EntitySet<product>(new Action<product>(this.attach_products), new Action<product>(this.detach_products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producttypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int producttypeID
		{
			get
			{
				return this._producttypeID;
			}
			set
			{
				if ((this._producttypeID != value))
				{
					this.OnproducttypeIDChanging(value);
					this.SendPropertyChanging();
					this._producttypeID = value;
					this.SendPropertyChanged("producttypeID");
					this.OnproducttypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producttypeomschrijving", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string producttypeomschrijving
		{
			get
			{
				return this._producttypeomschrijving;
			}
			set
			{
				if ((this._producttypeomschrijving != value))
				{
					this.OnproducttypeomschrijvingChanging(value);
					this.SendPropertyChanging();
					this._producttypeomschrijving = value;
					this.SendPropertyChanged("producttypeomschrijving");
					this.OnproducttypeomschrijvingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttype_product", Storage="_products", ThisKey="producttypeID", OtherKey="producttypeID")]
		public EntitySet<product> products
		{
			get
			{
				return this._products;
			}
			set
			{
				this._products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttype = this;
		}
		
		private void detach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttype = null;
		}
	}
}
#pragma warning restore 1591