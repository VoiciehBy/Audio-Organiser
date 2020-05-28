﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Audio_Organiser
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="muzyka")]
	public partial class DatabaseMusicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSong(Song instance);
    partial void UpdateSong(Song instance);
    partial void DeleteSong(Song instance);
    #endregion
		
		public DatabaseMusicDataContext() : 
				base(global::Audio_Organiser.Properties.Settings.Default.muzykaConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseMusicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseMusicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseMusicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseMusicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Song> Song
		{
			get
			{
				return this.GetTable<Song>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Song")]
	public partial class Song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _file;
		
		private string _artist;
		
		private string _title;
		
		private string _album;
		
		private System.Nullable<int> _year;
		
		private string _genre;
		
		private string _path;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnfileChanging(string value);
    partial void OnfileChanged();
    partial void OnartistChanging(string value);
    partial void OnartistChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnalbumChanging(string value);
    partial void OnalbumChanged();
    partial void OnyearChanging(System.Nullable<int> value);
    partial void OnyearChanged();
    partial void OngenreChanging(string value);
    partial void OngenreChanged();
    partial void OnpathChanging(string value);
    partial void OnpathChanged();
    #endregion
		
		public Song()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[file]", Storage="_file", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string file
		{
			get
			{
				return this._file;
			}
			set
			{
				if ((this._file != value))
				{
					this.OnfileChanging(value);
					this.SendPropertyChanging();
					this._file = value;
					this.SendPropertyChanged("file");
					this.OnfileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_artist", DbType="NVarChar(20)")]
		public string artist
		{
			get
			{
				return this._artist;
			}
			set
			{
				if ((this._artist != value))
				{
					this.OnartistChanging(value);
					this.SendPropertyChanging();
					this._artist = value;
					this.SendPropertyChanged("artist");
					this.OnartistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(30)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_album", DbType="NVarChar(20)")]
		public string album
		{
			get
			{
				return this._album;
			}
			set
			{
				if ((this._album != value))
				{
					this.OnalbumChanging(value);
					this.SendPropertyChanging();
					this._album = value;
					this.SendPropertyChanged("album");
					this.OnalbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="Int")]
		public System.Nullable<int> year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this.OnyearChanging(value);
					this.SendPropertyChanging();
					this._year = value;
					this.SendPropertyChanged("year");
					this.OnyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genre", DbType="NVarChar(20)")]
		public string genre
		{
			get
			{
				return this._genre;
			}
			set
			{
				if ((this._genre != value))
				{
					this.OngenreChanging(value);
					this.SendPropertyChanging();
					this._genre = value;
					this.SendPropertyChanged("genre");
					this.OngenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_path", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string path
		{
			get
			{
				return this._path;
			}
			set
			{
				if ((this._path != value))
				{
					this.OnpathChanging(value);
					this.SendPropertyChanging();
					this._path = value;
					this.SendPropertyChanged("path");
					this.OnpathChanged();
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
