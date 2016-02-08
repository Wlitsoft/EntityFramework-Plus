﻿// Description: Entity Framework Bulk Operations & Utilities (EF Bulk SaveChanges, Insert, Update, Delete, Merge | LINQ Query Cache, Deferred, Filter, IncludeFilter, IncludeOptimize | Audit)
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: https://github.com/zzzprojects/EntityFramework-Plus/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2016 ZZZ Projects. All rights reserved.

namespace Z.Test.EntityFramework.Plus
{
    public class Inheritance_TPH_Cat : Inheritance_TPH_Animal
    {
        public int ColumnCat { get; set; }

        public static Inheritance_TPH_Cat Create()
        {
            return new Inheritance_TPH_Cat();
        }
    }
}