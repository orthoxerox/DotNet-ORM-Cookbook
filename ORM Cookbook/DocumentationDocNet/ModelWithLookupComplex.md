﻿# CRUD Operations on Model with Object-Based Foreign Key

This use case demonstrates performing Create, Read, Update, and Delete operations on an object that has a foreign key reference to a lookup table. The FK reference is represented as an object.

## Prototype Repository

@snippet cs [..\Recipes.Core\ModelWithLookup\IEmployeeComplex.cs] IEmployeeComplex

@snippet cs [..\Recipes.Core\ModelWithLookup\IModelWithLookupComplexRepository`1.cs] IModelWithLookupComplexRepository{TEmployee}

## Database Views

@snippet text [..\OrmCookbookDB\HR\Views\EmployeeDetail.sql] 

## ADO.NET

In order to promote code reuse, object population has been moved into the model's constructor.

@snippet cs [..\Recipes.Ado\ModelWithLookup\EmployeeComplex.cs] EmployeeComplex

Likewise, a database view was used to join the Employee table with its lookup table(s).

@snippet cs [..\Recipes.Ado\ModelWithLookup\ModelWithLookupComplexRepository.cs] ModelWithLookupComplexRepository


## Chain

Chain does not support representing FK's as child objects for create/update operations. The FK must be exposed via the parent object.

Read operations must occur against a database view in order to get the properties from the child object. The `Decompose` attribute indicates that the child should be populated from the same view.

@snippet cs [..\Recipes.Tortuga.Chain\ModelWithLookup\EmployeeComplex.cs] EmployeeComplex

@snippet cs [..\Recipes.Tortuga.Chain\ModelWithLookup\ModelWithLookupComplexRepository.cs] ModelWithLookupComplexRepository


## Dapper

Dapper does not support representing FK's as child objects for create/update operations. The FK must be exposed via the parent object.

Read operations must occur against a database view in order to get the properties from the child object. The [Multi Mapping](https://github.com/StackExchange/Dapper#multi-mapping) overload indicates that the child should be populated from the same view. Use the `splitOn` parameter to indicate the primary key of the second object.

@snippet cs [..\Recipes.Dapper\ModelWithLookup\EmployeeComplex.cs] EmployeeComplex

@snippet cs [..\Recipes.Dapper\ModelWithLookup\ModelWithLookupComplexRepository.cs] ModelWithLookupComplexRepository

## Entity Framework Core

Child objects outside of the DBContext (e.g. from a REST call) need to be mapped to an object created by the DBContext.

This provides a layer of safety, as otherwise clients could override data in the lookup table.

@snippet cs [..\Recipes.EntityFrameworkCore\ModelWithLookup\ModelWithLookupComplexRepository.cs] ModelWithLookupComplexRepository

## LLBLGen Pro

As LLBLGen Pro supports change tracking in the entities it doesn't have to refetch an entity that's been updated. The repository code 
illustrates this. As it also by default persists all reachable entities in a graph, recursive saves are disabled here to make sure only the
entity that's passed in is persisted. 

Entity classes are always derived from a known base class so types created by the user aren't taken into account when traversing the graph, 
only entity classes. 

@snippet cs [..\Recipes.LLBLGenPro\Recipes\ModelWithLookup\ModelWithLookupComplexRepository.cs] ModelWithLookupComplexRepository


## NHibernate

TODO

## RepoDb

TODO

## ServiceStack

TODO
