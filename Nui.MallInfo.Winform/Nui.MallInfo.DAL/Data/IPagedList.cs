namespace Nui.MallInfo.DAL
{
    public interface IPagedList
    {
        int CurrentPageIndex { get; set; }
        int PageSize { get; set; }
        int recordsFiltered { get; set; }
    }
}
