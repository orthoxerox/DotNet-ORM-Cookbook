﻿using BenchmarkDotNet.Attributes;
using Recipes.Chain.SingleModelCrudAsync;
using System.Threading.Tasks;

namespace Performance
{
    partial class Benchmarks
    {
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_CreateAndReadBack()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.CreateAndReadBackAsync();
        }

        /// <summary>
        /// Create and delete a row.
        /// </summary>
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_CreateAndDeleteByModel()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.CreateAndDeleteByModelAsync();
        }

        /// <summary>
        /// Create and delete a row.
        /// </summary>
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_CreateAndDeleteByKey()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.CreateAndDeleteByKeyAsync();
        }

        /// <summary>
        /// Get all rows from a table.
        /// </summary>
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_GetAll()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.GetAllAsync();
        }

        /// <summary>
        /// Get a row using a primary key.
        /// </summary>
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_GetByKey()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.GetByKeyAsync();
        }

        /// <summary>
        /// Create and update a row.
        /// </summary>
        [Benchmark]
        public Task Chain_SingleModelCrudAsyncCompiledTests_CreateAndUpdate()
        {
            var test = new SingleModelCrudAsyncCompiledTests();
            return test.CreateAndUpdateAsync();
        }
    }
}
