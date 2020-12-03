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

namespace test
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBH_FastFood")]
	public partial class DataClassesStkpDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNGUYENLIEU(NGUYENLIEU instance);
    partial void UpdateNGUYENLIEU(NGUYENLIEU instance);
    partial void DeleteNGUYENLIEU(NGUYENLIEU instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    #endregion
		
		public DataClassesStkpDataContext() : 
				base(global::test.Properties.Settings.Default.QLBH_FastFoodConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStkpDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStkpDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStkpDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStkpDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<NGUYENLIEU> NGUYENLIEUs
		{
			get
			{
				return this.GetTable<NGUYENLIEU>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUYENLIEU")]
	public partial class NGUYENLIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNL;
		
		private string _TenNL;
		
		private int _GiaNL;
		
		private string _DonVi;
		
		private int _SLTonKho;
		
		private System.Nullable<bool> _TT_Ban;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNLChanging(int value);
    partial void OnMaNLChanged();
    partial void OnTenNLChanging(string value);
    partial void OnTenNLChanged();
    partial void OnGiaNLChanging(int value);
    partial void OnGiaNLChanged();
    partial void OnDonViChanging(string value);
    partial void OnDonViChanged();
    partial void OnSLTonKhoChanging(int value);
    partial void OnSLTonKhoChanged();
    partial void OnTT_BanChanging(System.Nullable<bool> value);
    partial void OnTT_BanChanged();
    #endregion
		
		public NGUYENLIEU()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNL", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaNL
		{
			get
			{
				return this._MaNL;
			}
			set
			{
				if ((this._MaNL != value))
				{
					this.OnMaNLChanging(value);
					this.SendPropertyChanging();
					this._MaNL = value;
					this.SendPropertyChanged("MaNL");
					this.OnMaNLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNL", DbType="NVarChar(30)")]
		public string TenNL
		{
			get
			{
				return this._TenNL;
			}
			set
			{
				if ((this._TenNL != value))
				{
					this.OnTenNLChanging(value);
					this.SendPropertyChanging();
					this._TenNL = value;
					this.SendPropertyChanged("TenNL");
					this.OnTenNLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNL", DbType="Int NOT NULL")]
		public int GiaNL
		{
			get
			{
				return this._GiaNL;
			}
			set
			{
				if ((this._GiaNL != value))
				{
					this.OnGiaNLChanging(value);
					this.SendPropertyChanging();
					this._GiaNL = value;
					this.SendPropertyChanged("GiaNL");
					this.OnGiaNLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonVi", DbType="NVarChar(15)")]
		public string DonVi
		{
			get
			{
				return this._DonVi;
			}
			set
			{
				if ((this._DonVi != value))
				{
					this.OnDonViChanging(value);
					this.SendPropertyChanging();
					this._DonVi = value;
					this.SendPropertyChanged("DonVi");
					this.OnDonViChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLTonKho", DbType="Int NOT NULL")]
		public int SLTonKho
		{
			get
			{
				return this._SLTonKho;
			}
			set
			{
				if ((this._SLTonKho != value))
				{
					this.OnSLTonKhoChanging(value);
					this.SendPropertyChanging();
					this._SLTonKho = value;
					this.SendPropertyChanged("SLTonKho");
					this.OnSLTonKhoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TT_Ban", DbType="Bit")]
		public System.Nullable<bool> TT_Ban
		{
			get
			{
				return this._TT_Ban;
			}
			set
			{
				if ((this._TT_Ban != value))
				{
					this.OnTT_BanChanging(value);
					this.SendPropertyChanging();
					this._TT_Ban = value;
					this.SendPropertyChanged("TT_Ban");
					this.OnTT_BanChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _HoTen;
		
		private System.Nullable<bool> _GT;
		
		private string _CMND;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private System.Nullable<bool> _TT_Lam;
		
		private string _MatKhau;
		
		private System.Nullable<int> _MaCV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnGTChanging(System.Nullable<bool> value);
    partial void OnGTChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnTT_LamChanging(System.Nullable<bool> value);
    partial void OnTT_LamChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnMaCVChanging(System.Nullable<int> value);
    partial void OnMaCVChanged();
    #endregion
		
		public NHANVIEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(30)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GT", DbType="Bit")]
		public System.Nullable<bool> GT
		{
			get
			{
				return this._GT;
			}
			set
			{
				if ((this._GT != value))
				{
					this.OnGTChanging(value);
					this.SendPropertyChanging();
					this._GT = value;
					this.SendPropertyChanged("GT");
					this.OnGTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="VarChar(15)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(12)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TT_Lam", DbType="Bit")]
		public System.Nullable<bool> TT_Lam
		{
			get
			{
				return this._TT_Lam;
			}
			set
			{
				if ((this._TT_Lam != value))
				{
					this.OnTT_LamChanging(value);
					this.SendPropertyChanging();
					this._TT_Lam = value;
					this.SendPropertyChanged("TT_Lam");
					this.OnTT_LamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCV", DbType="Int")]
		public System.Nullable<int> MaCV
		{
			get
			{
				return this._MaCV;
			}
			set
			{
				if ((this._MaCV != value))
				{
					this.OnMaCVChanging(value);
					this.SendPropertyChanging();
					this._MaCV = value;
					this.SendPropertyChanged("MaCV");
					this.OnMaCVChanged();
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
