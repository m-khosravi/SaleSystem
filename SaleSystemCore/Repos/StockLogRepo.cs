﻿using SaleSystemCore.Repos.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SaleSystemCore.Models;
using Microsoft.EntityFrameworkCore;
using SaleSystemCore.EF;
using System.Linq;

namespace SaleSystemCore.Repos
{
    public class StockLogRepo : RepoBase<StockLog>
    {
        public StockLogRepo(DbContextOptions<CoreContext> options)
            : base(options)
        { }
        public StockLogRepo()
        { }

        public override IEnumerable<StockLog> GetAll()
            => Table.AsNoTracking().Where(l => !l.IsDeleted).OrderBy(x => x.CreateDate);
        public override IEnumerable<StockLog> GetRange(int skip, int take)
            => GetRange(Table.AsNoTracking().Where(l => !l.IsDeleted).OrderBy(x => x.CreateDate), skip, take);
    }
}
