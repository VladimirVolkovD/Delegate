





































class CustomStringComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        int firstLenght = x?.Length ?? 0;
        int secondLenght = y?.Length ?? 0;
        return firstLenght - secondLenght;
    }
}
