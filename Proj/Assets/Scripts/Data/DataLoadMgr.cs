using System;
using CsvHelper;
using System.IO;
using System.Text;
using System.Collections.Generic;
using CsvHelper.Configuration;
using UnityEngine;

namespace DesignData{

	public interface IData
	{
		string ID { get; set; }
	}
	public class DataMgr
	{
		public static DataMgr _instance;
		public static DataMgr Ins
		{
			get
			{
				if (_instance == null)
				{
					_instance = new DataMgr();
				}
				return _instance; 
			}
			private set{}
		}

		private DataMgr()
		{
			LoadAllData();
		}
		public static Dictionary<string, T> LoadCsvFile<T, U>(string path) where U : CsvClassMap where T : IData
		{
			var dic = new Dictionary<string, T>();
			var fullPath = Application.dataPath+"/Resources/"+path;
			using (var textReader = new StreamReader(fullPath, Encoding.UTF8))
			{
				using (var csv = new CsvReader(textReader))
				{
					csv.Configuration.AllowComments = true; // 允许注释
					csv.Configuration.RegisterClassMap<U>(); // 注册映射类
															 // csv.Configuration.Comment = '#'; // 默认 #开头的行不会加载进来
															 // csv.Configuration.HasHeaderRecord = true; // 默认有头记录
					while (csv.Read())
					{
						var data = csv.GetRecord<T>();
						dic.Add(data.ID.ToString(), data);
					}

				}

			}
			return dic;
		}

		////此处添加新的策划表数据，以及调用，同时新建文件来定义数据结构//////////
		public Dictionary<string,Cake> CakeDic;
		void LoadAllData()
		{
            CakeDic = LoadCsvFile<Cake, CakeMap>("Data/Cakes.csv");//相对于Resources目录

            // 数据访问举例：DesignData.DataMgr.Ins.CakeDic["1"].Name
        }

    }
}