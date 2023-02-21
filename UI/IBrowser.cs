using System;
using InvoiceCloud.UI.Pages;

namespace InvoiceCloud.UI
{
	public interface IBrowser
	{
        public T NavigateTo<T>(string url="") where T : IPage;

    }
}

