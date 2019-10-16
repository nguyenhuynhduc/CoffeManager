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

namespace LeanDevExpress
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LeanDeveExpress")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblBill(tblBill instance);
    partial void UpdatetblBill(tblBill instance);
    partial void DeletetblBill(tblBill instance);
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    partial void InserttblDetailBill(tblDetailBill instance);
    partial void UpdatetblDetailBill(tblDetailBill instance);
    partial void DeletetblDetailBill(tblDetailBill instance);
    partial void InserttblOder(tblOder instance);
    partial void UpdatetblOder(tblOder instance);
    partial void DeletetblOder(tblOder instance);
    partial void InserttblProduct(tblProduct instance);
    partial void UpdatetblProduct(tblProduct instance);
    partial void DeletetblProduct(tblProduct instance);
    partial void InserttblTable(tblTable instance);
    partial void UpdatetblTable(tblTable instance);
    partial void DeletetblTable(tblTable instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LeanDevExpress.Properties.Settings.Default.LeanDeveExpressConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblBill> tblBills
		{
			get
			{
				return this.GetTable<tblBill>();
			}
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		public System.Data.Linq.Table<tblDetailBill> tblDetailBills
		{
			get
			{
				return this.GetTable<tblDetailBill>();
			}
		}
		
		public System.Data.Linq.Table<tblOder> tblOders
		{
			get
			{
				return this.GetTable<tblOder>();
			}
		}
		
		public System.Data.Linq.Table<tblProduct> tblProducts
		{
			get
			{
				return this.GetTable<tblProduct>();
			}
		}
		
		public System.Data.Linq.Table<tblTable> tblTables
		{
			get
			{
				return this.GetTable<tblTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblBill")]
	public partial class tblBill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idBill;
		
		private int _cost;
		
		private System.DateTime _dateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidBillChanging(int value);
    partial void OnidBillChanged();
    partial void OncostChanging(int value);
    partial void OncostChanged();
    partial void OndateTimeChanging(System.DateTime value);
    partial void OndateTimeChanged();
    #endregion
		
		public tblBill()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idBill", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idBill
		{
			get
			{
				return this._idBill;
			}
			set
			{
				if ((this._idBill != value))
				{
					this.OnidBillChanging(value);
					this.SendPropertyChanging();
					this._idBill = value;
					this.SendPropertyChanged("idBill");
					this.OnidBillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="Int NOT NULL")]
		public int cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateTime", DbType="DateTime NOT NULL")]
		public System.DateTime dateTime
		{
			get
			{
				return this._dateTime;
			}
			set
			{
				if ((this._dateTime != value))
				{
					this.OndateTimeChanging(value);
					this.SendPropertyChanging();
					this._dateTime = value;
					this.SendPropertyChanged("dateTime");
					this.OndateTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _username;
		
		private string _password;
		
		private int _type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OntypeChanging(int value);
    partial void OntypeChanged();
    #endregion
		
		public tblUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="Int NOT NULL")]
		public int type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblDetailBill")]
	public partial class tblDetailBill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDetailBill;
		
		private int _idBill;
		
		private int _idProduct;
		
		private int _amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDetailBillChanging(int value);
    partial void OnidDetailBillChanged();
    partial void OnidBillChanging(int value);
    partial void OnidBillChanged();
    partial void OnidProductChanging(int value);
    partial void OnidProductChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    #endregion
		
		public tblDetailBill()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDetailBill", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idDetailBill
		{
			get
			{
				return this._idDetailBill;
			}
			set
			{
				if ((this._idDetailBill != value))
				{
					this.OnidDetailBillChanging(value);
					this.SendPropertyChanging();
					this._idDetailBill = value;
					this.SendPropertyChanged("idDetailBill");
					this.OnidDetailBillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idBill", DbType="Int NOT NULL")]
		public int idBill
		{
			get
			{
				return this._idBill;
			}
			set
			{
				if ((this._idBill != value))
				{
					this.OnidBillChanging(value);
					this.SendPropertyChanging();
					this._idBill = value;
					this.SendPropertyChanged("idBill");
					this.OnidBillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProduct", DbType="Int NOT NULL")]
		public int idProduct
		{
			get
			{
				return this._idProduct;
			}
			set
			{
				if ((this._idProduct != value))
				{
					this.OnidProductChanging(value);
					this.SendPropertyChanging();
					this._idProduct = value;
					this.SendPropertyChanged("idProduct");
					this.OnidProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblOder")]
	public partial class tblOder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idOrder;
		
		private int _idProduct;
		
		private int _amount;
		
		private int _idTable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidOrderChanging(int value);
    partial void OnidOrderChanged();
    partial void OnidProductChanging(int value);
    partial void OnidProductChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    partial void OnidTableChanging(int value);
    partial void OnidTableChanged();
    #endregion
		
		public tblOder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOrder", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idOrder
		{
			get
			{
				return this._idOrder;
			}
			set
			{
				if ((this._idOrder != value))
				{
					this.OnidOrderChanging(value);
					this.SendPropertyChanging();
					this._idOrder = value;
					this.SendPropertyChanged("idOrder");
					this.OnidOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProduct", DbType="Int NOT NULL")]
		public int idProduct
		{
			get
			{
				return this._idProduct;
			}
			set
			{
				if ((this._idProduct != value))
				{
					this.OnidProductChanging(value);
					this.SendPropertyChanging();
					this._idProduct = value;
					this.SendPropertyChanged("idProduct");
					this.OnidProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", DbType="Int NOT NULL")]
		public int idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblProduct")]
	public partial class tblProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProduct;
		
		private string _nameProduct;
		
		private int _price;
		
		private int _amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProductChanging(int value);
    partial void OnidProductChanged();
    partial void OnnameProductChanging(string value);
    partial void OnnameProductChanged();
    partial void OnpriceChanging(int value);
    partial void OnpriceChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    #endregion
		
		public tblProduct()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProduct", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idProduct
		{
			get
			{
				return this._idProduct;
			}
			set
			{
				if ((this._idProduct != value))
				{
					this.OnidProductChanging(value);
					this.SendPropertyChanging();
					this._idProduct = value;
					this.SendPropertyChanged("idProduct");
					this.OnidProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameProduct", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nameProduct
		{
			get
			{
				return this._nameProduct;
			}
			set
			{
				if ((this._nameProduct != value))
				{
					this.OnnameProductChanging(value);
					this.SendPropertyChanging();
					this._nameProduct = value;
					this.SendPropertyChanged("nameProduct");
					this.OnnameProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int NOT NULL")]
		public int price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTable")]
	public partial class tblTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idTable;
		
		private int _name;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTableChanging(int value);
    partial void OnidTableChanged();
    partial void OnnameChanging(int value);
    partial void OnnameChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public tblTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="Int NOT NULL")]
		public int name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
}
#pragma warning restore 1591