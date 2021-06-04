using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity_News.ViewModel
{
    public class CelebCategoryViewModel
	{

		public CelebCategoryViewModel(List<SelectableData<CelebsData>> data)
		{
			DataList = data;
		}

		// As example if you need to convert
		//private void LoadData(List<ExampleData> data)
		//{
		//	var list = new List<SelectableData<ExampleData>>();

		//	foreach (var item in data)
		//		list.Add(new SelectableData<ExampleData>() { Data = item });

		//	DataList = list;
		//}

		public List<SelectableData<CelebData>> DataList { get; set; }

		public List<SelectableData<CelebData>> GetNewData()
		{
			var list = new List<SelectableData<CelebData>>();

			foreach (var data in DataList)
				list.Add(new SelectableData<CelebData>() { Data = data.Data.Clone(), Selected = data.Selected });

			return list;
		}

		public ICommand FinishCommand
		{
			get
			{
				return new Command(async () =>
				{
					MainPageViewModel.SelectedData = GetNewData();
					await App.NavPage.PopAsync();
				});
			}

		}

	}
}
