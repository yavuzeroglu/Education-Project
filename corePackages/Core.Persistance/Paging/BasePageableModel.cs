﻿namespace Core.Persistance.Paging
{
    public class BasePageableModel
    {
        public int Index { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public bool HasPreivous { get; set; }
        public bool HasNext { get; set; }
    }

}
