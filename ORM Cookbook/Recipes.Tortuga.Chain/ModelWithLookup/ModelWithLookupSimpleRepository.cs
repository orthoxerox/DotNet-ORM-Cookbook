﻿using Recipes.ModelWithLookup;
using System;
using System.Collections.Generic;
using Tortuga.Chain;

namespace Recipes.Chain.ModelWithLookup
{
    public class ModelWithLookupSimpleRepository : IModelWithLookupSimpleRepository<EmployeeSimple>
    {
        const string TableName = "HR.Employee";
        const string ClassificationTableName = "HR.EmployeeClassification";
        readonly SqlServerDataSource m_DataSource;

        public ModelWithLookupSimpleRepository(SqlServerDataSource dataSource)
        {
            m_DataSource = dataSource;
        }

        public int Create(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            return m_DataSource.Insert(employee).ToInt32().Execute();
        }

        public void Delete(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            m_DataSource.Delete(employee).Execute();
        }

        public void DeleteByKey(int employeeKey)
        {
            m_DataSource.DeleteByKey(TableName, employeeKey).Execute();
        }

        public IList<EmployeeSimple> FindByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeSimple> GetAll()
        {
            return m_DataSource.From(TableName).ToCollection<EmployeeSimple>().Execute();
        }

        public EmployeeSimple? GetByKey(int employeeKey)
        {
            return m_DataSource.GetByKey(TableName, employeeKey).ToObject<EmployeeSimple>(RowOptions.AllowEmptyResults).Execute();
        }

        public IEmployeeClassification? GetClassification(int employeeClassificationKey)
        {
            return m_DataSource.GetByKey(ClassificationTableName, employeeClassificationKey).ToObject<EmployeeClassification>().Execute();
        }

        public void Update(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            m_DataSource.Update(employee).Execute();
        }
    }
}
