﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using LLBLGenPro.OrmCookbook.HelperClasses;
using LLBLGenPro.OrmCookbook.FactoryClasses;
using LLBLGenPro.OrmCookbook.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenPro.OrmCookbook.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Division'.<br/><br/></summary>
	[Serializable]
	public partial class DivisionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<DepartmentEntity> _departments;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static DivisionEntityStaticMetaData _staticMetaData = new DivisionEntityStaticMetaData();
		private static DivisionRelations _relationsFactory = new DivisionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Departments</summary>
			public static readonly string Departments = "Departments";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class DivisionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public DivisionEntityStaticMetaData()
			{
				SetEntityCoreInfo("DivisionEntity", InheritanceHierarchyType.None, false, (int)LLBLGenPro.OrmCookbook.EntityType.DivisionEntity, typeof(DivisionEntity), typeof(DivisionEntityFactory), false);
				AddNavigatorMetaData<DivisionEntity, EntityCollection<DepartmentEntity>>("Departments", a => a._departments, (a, b) => a._departments = b, a => a.Departments, () => new DivisionRelations().DepartmentEntityUsingDivisionKey, typeof(DepartmentEntity), (int)LLBLGenPro.OrmCookbook.EntityType.DepartmentEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static DivisionEntity()
		{
		}

		/// <summary> CTor</summary>
		public DivisionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DivisionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DivisionEntity</param>
		public DivisionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="divisionKey">PK value for Division which data should be fetched into this Division object</param>
		public DivisionEntity(System.Int32 divisionKey) : this(divisionKey, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="divisionKey">PK value for Division which data should be fetched into this Division object</param>
		/// <param name="validator">The custom validator object for this DivisionEntity</param>
		public DivisionEntity(System.Int32 divisionKey, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DivisionKey = divisionKey;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DivisionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: DivisionName .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCDivisionName()
		{
			var filter = new PredicateExpression();
			filter.Add(LLBLGenPro.OrmCookbook.HelperClasses.DivisionFields.DivisionName == this.Fields.GetCurrentValue((int)DivisionFieldIndex.DivisionName));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Department' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDepartments() { return CreateRelationInfoForNavigator("Departments"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DivisionEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static DivisionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Department' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDepartments { get { return _staticMetaData.GetPrefetchPathElement("Departments", CommonEntityBase.CreateEntityCollection<DepartmentEntity>()); } }

		/// <summary>The DivisionKey property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."DivisionKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DivisionKey
		{
			get { return (System.Int32)GetValue((int)DivisionFieldIndex.DivisionKey, true); }
			set { SetValue((int)DivisionFieldIndex.DivisionKey, value); }		}

		/// <summary>The DivisionName property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."DivisionName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DivisionName
		{
			get { return (System.String)GetValue((int)DivisionFieldIndex.DivisionName, true); }
			set	{ SetValue((int)DivisionFieldIndex.DivisionName, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'DepartmentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DepartmentEntity))]
		public virtual EntityCollection<DepartmentEntity> Departments { get { return GetOrCreateEntityCollection<DepartmentEntity, DepartmentEntityFactory>("Division", true, false, ref _departments); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace LLBLGenPro.OrmCookbook
{
	public enum DivisionFieldIndex
	{
		///<summary>DivisionKey. </summary>
		DivisionKey,
		///<summary>DivisionName. </summary>
		DivisionName,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace LLBLGenPro.OrmCookbook.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Division. </summary>
	public partial class DivisionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between DivisionEntity and DepartmentEntity over the 1:n relation they have, using the relation between the fields: Division.DivisionKey - Department.DivisionKey</summary>
		public virtual IEntityRelation DepartmentEntityUsingDivisionKey
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Departments", true, new[] { DivisionFields.DivisionKey, DepartmentFields.DivisionKey }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticDivisionRelations
	{
		internal static readonly IEntityRelation DepartmentEntityUsingDivisionKeyStatic = new DivisionRelations().DepartmentEntityUsingDivisionKey;

		/// <summary>CTor</summary>
		static StaticDivisionRelations() { }
	}
}
