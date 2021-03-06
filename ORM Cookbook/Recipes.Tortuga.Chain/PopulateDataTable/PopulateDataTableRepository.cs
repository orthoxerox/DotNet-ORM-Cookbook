﻿using Recipes.PopulateDataTable;
using System.Data;
using Tortuga.Chain;

namespace Recipes.Chain.PopulateDataTable
{
    public class PopulateDataTableRepository : IPopulateDataTableRepository
    {
        const string TableName = "HR.EmployeeClassification";
        readonly SqlServerDataSource m_DataSource;

        public PopulateDataTableRepository(SqlServerDataSource dataSource)
        {
            m_DataSource = dataSource;
        }

        public DataTable FindByFlags(bool isExempt, bool isEmployee)
        {
            return m_DataSource.From(TableName, new { isExempt, isEmployee }).ToDataTable().Execute();
        }

        public DataTable GetAll()
        {
            return m_DataSource.From(TableName).ToDataTable().Execute();
        }
    }
}
