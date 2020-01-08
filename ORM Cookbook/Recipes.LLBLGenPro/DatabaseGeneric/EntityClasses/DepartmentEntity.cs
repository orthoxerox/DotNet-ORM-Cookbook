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
	/// <summary>Entity class which represents the entity 'Department'.<br/><br/></summary>
	[Serializable]
	public partial class DepartmentEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private DivisionEntity _division;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static DepartmentEntityStaticMetaData _staticMetaData = new DepartmentEntityStaticMetaData();
		private static DepartmentRelations _relationsFactory = new DepartmentRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Division</summary>
			public static readonly string Division = "Division";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class DepartmentEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public DepartmentEntityStaticMetaData()
			{
				SetEntityCoreInfo("DepartmentEntity", InheritanceHierarchyType.None, false, (int)LLBLGenPro.OrmCookbook.EntityType.DepartmentEntity, typeof(DepartmentEntity), typeof(DepartmentEntityFactory), false);
				AddNavigatorMetaData<DepartmentEntity, DivisionEntity>("Division", "Departments", (a, b) => a._division = b, a => a._division, (a, b) => a.Division = b, LLBLGenPro.OrmCookbook.RelationClasses.StaticDepartmentRelations.DivisionEntityUsingDivisionKeyStatic, ()=>new DepartmentRelations().DivisionEntityUsingDivisionKey, null, new int[] { (int)DepartmentFieldIndex.DivisionKey }, null, true, (int)LLBLGenPro.OrmCookbook.EntityType.DivisionEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static DepartmentEntity()
		{
		}

		/// <summary> CTor</summary>
		public DepartmentEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DepartmentEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DepartmentEntity</param>
		public DepartmentEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="departmentKey">PK value for Department which data should be fetched into this Department object</param>
		public DepartmentEntity(System.Int32 departmentKey) : this(departmentKey, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="departmentKey">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="validator">The custom validator object for this DepartmentEntity</param>
		public DepartmentEntity(System.Int32 departmentKey, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DepartmentKey = departmentKey;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DepartmentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: DepartmentName .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCDepartmentName()
		{
			var filter = new PredicateExpression();
			filter.Add(LLBLGenPro.OrmCookbook.HelperClasses.DepartmentFields.DepartmentName == this.Fields.GetCurrentValue((int)DepartmentFieldIndex.DepartmentName));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Division' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDivision() { return CreateRelationInfoForNavigator("Division"); }
		
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
		/// <param name="validator">The validator object for this DepartmentEntity</param>
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
		public static DepartmentRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Division' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDivision { get { return _staticMetaData.GetPrefetchPathElement("Division", CommonEntityBase.CreateEntityCollection<DivisionEntity>()); } }

		/// <summary>The DepartmentKey property of the Entity Department<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Department"."DepartmentKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DepartmentKey
		{
			get { return (System.Int32)GetValue((int)DepartmentFieldIndex.DepartmentKey, true); }
			set { SetValue((int)DepartmentFieldIndex.DepartmentKey, value); }		}

		/// <summary>The DepartmentName property of the Entity Department<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Department"."DepartmentName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DepartmentName
		{
			get { return (System.String)GetValue((int)DepartmentFieldIndex.DepartmentName, true); }
			set	{ SetValue((int)DepartmentFieldIndex.DepartmentName, value); }
		}

		/// <summary>The DivisionKey property of the Entity Department<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Department"."DivisionKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DivisionKey
		{
			get { return (System.Int32)GetValue((int)DepartmentFieldIndex.DivisionKey, true); }
			set	{ SetValue((int)DepartmentFieldIndex.DivisionKey, value); }
		}

		/// <summary>Gets / sets related entity of type 'DivisionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual DivisionEntity Division
		{
			get { return _division; }
			set { SetSingleRelatedEntityNavigator(value, "Division"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace LLBLGenPro.OrmCookbook
{
	public enum DepartmentFieldIndex
	{
		///<summary>DepartmentKey. </summary>
		DepartmentKey,
		///<summary>DepartmentName. </summary>
		DepartmentName,
		///<summary>DivisionKey. </summary>
		DivisionKey,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace LLBLGenPro.OrmCookbook.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Department. </summary>
	public partial class DepartmentRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between DepartmentEntity and DivisionEntity over the m:1 relation they have, using the relation between the fields: Department.DivisionKey - Division.DivisionKey</summary>
		public virtual IEntityRelation DivisionEntityUsingDivisionKey
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Division", false, new[] { DivisionFields.DivisionKey, DepartmentFields.DivisionKey }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticDepartmentRelations
	{
		internal static readonly IEntityRelation DivisionEntityUsingDivisionKeyStatic = new DepartmentRelations().DivisionEntityUsingDivisionKey;

		/// <summary>CTor</summary>
		static StaticDepartmentRelations() { }
	}
}