﻿// Description: Entity Framework Bulk Operations & Utilities (EF Bulk SaveChanges, Insert, Update, Delete, Merge | LINQ Query Cache, Deferred, Filter, IncludeFilter, IncludeOptimize | Audit)
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: https://github.com/zzzprojects/EntityFramework-Plus/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2016 ZZZ Projects. All rights reserved.


#if STANDALONE
namespace Z.EntityFramework.Plus
{
    internal class ExceptionMessage
    {
        public static string GeneralException = "Oops! A general error has occurred. Please report the issue including the stack trace to our support team: info@zzzprojects.com";
        public static string QueryIncludeFilter_ArgumentExpression = "Oops! immediate method with expression argument are not supported in EF+ Query IncludeFilter. For more information, contact us: info@zzzprojects.com";
        public static string QueryIncludeFilter_CreateQueryElement = "Oops! Select projection are not supported in EF+ Query IncludeFilter. For more information, contact us: info@zzzprojects.com";
        public static string QueryIncludeFilter_Include = "Oops! 'Include' method from Entity Framework is not supported, use only IncludeFilter method. For more information, contact us: info@zzzprojects.com";
    }
}
#endif