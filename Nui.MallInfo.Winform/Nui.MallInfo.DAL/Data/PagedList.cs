using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.DAL
{
    public class PagedList<T> : IPagedList
    {
        public PagedList()
        {
            this.Data = new List<T>();
        }

        public PagedList(IList<T> items, int pageIndex, int pageSize)
            : this()
        {
            PageSize = pageSize;
            recordsFiltered = items.Count;
            CurrentPageIndex = pageIndex;
            for (int i = StartRecordIndex - 1; i < EndRecordIndex; i++)
            {
                this.Data.Add(items[i]);
            }
        }

        public PagedList(IEnumerable<T> items, int pageIndex, int pageSize, int totalItemCount)
            : this()
        {
            this.Data.AddRange(items);
            recordsFiltered = totalItemCount;
            CurrentPageIndex = pageIndex;
            PageSize = pageSize;
        }

        public int CurrentPageIndex { get; set; }
        public int PageSize { get; set; }
        public string draw { get; set; }
        public int recordsFiltered { get; set; }//recordsTotal
        public int recordsTotal { get { return recordsFiltered; } }//recordsFiltered
        public int TotalPageCount { get { return (int)Math.Ceiling(recordsFiltered / (double)PageSize); } }
        public int StartRecordIndex { get { return (CurrentPageIndex - 1) * PageSize + 1; } }
        public int EndRecordIndex { get { return recordsFiltered > CurrentPageIndex * PageSize ? CurrentPageIndex * PageSize : recordsFiltered; } }

        public List<T> Data { get; set; }

    }

    public static class PageLinqExtensions
    {
        public static PagedList<T> ToPagedList<T>
            (
                this IQueryable<T> allItems,
                int pageIndex,
                int pageSize
            )
        {
            if (pageIndex < 1)
                pageIndex = 1;
            var itemIndex = (pageIndex - 1) * pageSize;
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize);
            var totalItemCount = allItems.Count();
            return new PagedList<T>(pageOfItems, pageIndex, pageSize, totalItemCount);
        }
    }
}
