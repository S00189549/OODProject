﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ExerciseDatabaseModel", "FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(OOD_project.tbl_BodyPart), "tbl_Exercises", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OOD_project.tbl_Exercises), true)]
[assembly: EdmRelationshipAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToExercises", "tbl_Exercises", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(OOD_project.tbl_Exercises), "tbl_Workout", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OOD_project.tbl_Workout), true)]
[assembly: EdmRelationshipAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToProfile", "tbl_Profiles", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(OOD_project.tbl_Profiles), "tbl_Workout", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OOD_project.tbl_Workout), true)]

#endregion

namespace OOD_project
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdilsGymEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdilsGymEntities object using the connection string found in the 'AdilsGymEntities' section of the application configuration file.
        /// </summary>
        public AdilsGymEntities() : base("name=AdilsGymEntities", "AdilsGymEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdilsGymEntities object.
        /// </summary>
        public AdilsGymEntities(string connectionString) : base(connectionString, "AdilsGymEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdilsGymEntities object.
        /// </summary>
        public AdilsGymEntities(EntityConnection connection) : base(connection, "AdilsGymEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_BodyPart> tbl_BodyPart
        {
            get
            {
                if ((_tbl_BodyPart == null))
                {
                    _tbl_BodyPart = base.CreateObjectSet<tbl_BodyPart>("tbl_BodyPart");
                }
                return _tbl_BodyPart;
            }
        }
        private ObjectSet<tbl_BodyPart> _tbl_BodyPart;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_Exercises> tbl_Exercises
        {
            get
            {
                if ((_tbl_Exercises == null))
                {
                    _tbl_Exercises = base.CreateObjectSet<tbl_Exercises>("tbl_Exercises");
                }
                return _tbl_Exercises;
            }
        }
        private ObjectSet<tbl_Exercises> _tbl_Exercises;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_Profiles> tbl_Profiles
        {
            get
            {
                if ((_tbl_Profiles == null))
                {
                    _tbl_Profiles = base.CreateObjectSet<tbl_Profiles>("tbl_Profiles");
                }
                return _tbl_Profiles;
            }
        }
        private ObjectSet<tbl_Profiles> _tbl_Profiles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_Workout> tbl_Workout
        {
            get
            {
                if ((_tbl_Workout == null))
                {
                    _tbl_Workout = base.CreateObjectSet<tbl_Workout>("tbl_Workout");
                }
                return _tbl_Workout;
            }
        }
        private ObjectSet<tbl_Workout> _tbl_Workout;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_BodyPart EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_BodyPart(tbl_BodyPart tbl_BodyPart)
        {
            base.AddObject("tbl_BodyPart", tbl_BodyPart);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_Exercises EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_Exercises(tbl_Exercises tbl_Exercises)
        {
            base.AddObject("tbl_Exercises", tbl_Exercises);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_Profiles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_Profiles(tbl_Profiles tbl_Profiles)
        {
            base.AddObject("tbl_Profiles", tbl_Profiles);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_Workout EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_Workout(tbl_Workout tbl_Workout)
        {
            base.AddObject("tbl_Workout", tbl_Workout);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ExerciseDatabaseModel", Name="tbl_BodyPart")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_BodyPart : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_BodyPart object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static tbl_BodyPart Createtbl_BodyPart(global::System.Int32 id, global::System.String name)
        {
            tbl_BodyPart tbl_BodyPart = new tbl_BodyPart();
            tbl_BodyPart.Id = id;
            tbl_BodyPart.Name = name;
            return tbl_BodyPart;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Exercises_ToBodyPart", "tbl_Exercises")]
        public EntityCollection<tbl_Exercises> tbl_Exercises
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_Exercises");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_Exercises", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ExerciseDatabaseModel", Name="tbl_Exercises")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_Exercises : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_Exercises object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="reps">Initial value of the Reps property.</param>
        /// <param name="sets">Initial value of the Sets property.</param>
        /// <param name="bodyPartID">Initial value of the BodyPartID property.</param>
        public static tbl_Exercises Createtbl_Exercises(global::System.Int32 id, global::System.String name, global::System.Int32 reps, global::System.Int32 sets, global::System.Int32 bodyPartID)
        {
            tbl_Exercises tbl_Exercises = new tbl_Exercises();
            tbl_Exercises.Id = id;
            tbl_Exercises.Name = name;
            tbl_Exercises.Reps = reps;
            tbl_Exercises.Sets = sets;
            tbl_Exercises.BodyPartID = bodyPartID;
            return tbl_Exercises;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Reps
        {
            get
            {
                return _Reps;
            }
            set
            {
                OnRepsChanging(value);
                ReportPropertyChanging("Reps");
                _Reps = StructuralObject.SetValidValue(value, "Reps");
                ReportPropertyChanged("Reps");
                OnRepsChanged();
            }
        }
        private global::System.Int32 _Reps;
        partial void OnRepsChanging(global::System.Int32 value);
        partial void OnRepsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Sets
        {
            get
            {
                return _Sets;
            }
            set
            {
                OnSetsChanging(value);
                ReportPropertyChanging("Sets");
                _Sets = StructuralObject.SetValidValue(value, "Sets");
                ReportPropertyChanged("Sets");
                OnSetsChanged();
            }
        }
        private global::System.Int32 _Sets;
        partial void OnSetsChanging(global::System.Int32 value);
        partial void OnSetsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BodyPartID
        {
            get
            {
                return _BodyPartID;
            }
            set
            {
                OnBodyPartIDChanging(value);
                ReportPropertyChanging("BodyPartID");
                _BodyPartID = StructuralObject.SetValidValue(value, "BodyPartID");
                ReportPropertyChanged("BodyPartID");
                OnBodyPartIDChanged();
            }
        }
        private global::System.Int32 _BodyPartID;
        partial void OnBodyPartIDChanging(global::System.Int32 value);
        partial void OnBodyPartIDChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart")]
        public tbl_BodyPart tbl_BodyPart
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_BodyPart>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_BodyPart>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_BodyPart> tbl_BodyPartReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_BodyPart>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_BodyPart>("ExerciseDatabaseModel.FK_tbl_Exercises_ToBodyPart", "tbl_BodyPart", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToExercises", "tbl_Workout")]
        public EntityCollection<tbl_Workout> tbl_Workout
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_Workout>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Workout");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_Workout>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Workout", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ExerciseDatabaseModel", Name="tbl_Profiles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_Profiles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_Profiles object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static tbl_Profiles Createtbl_Profiles(global::System.Int32 id, global::System.String name)
        {
            tbl_Profiles tbl_Profiles = new tbl_Profiles();
            tbl_Profiles.Id = id;
            tbl_Profiles.Name = name;
            return tbl_Profiles;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToProfile", "tbl_Workout")]
        public EntityCollection<tbl_Workout> tbl_Workout
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_Workout>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Workout");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_Workout>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Workout", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ExerciseDatabaseModel", Name="tbl_Workout")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_Workout : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_Workout object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="exerciseID">Initial value of the ExerciseID property.</param>
        /// <param name="saveDate">Initial value of the SaveDate property.</param>
        /// <param name="profileID">Initial value of the ProfileID property.</param>
        public static tbl_Workout Createtbl_Workout(global::System.Int32 id, global::System.Int32 exerciseID, global::System.DateTime saveDate, global::System.Int32 profileID)
        {
            tbl_Workout tbl_Workout = new tbl_Workout();
            tbl_Workout.Id = id;
            tbl_Workout.ExerciseID = exerciseID;
            tbl_Workout.SaveDate = saveDate;
            tbl_Workout.ProfileID = profileID;
            return tbl_Workout;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ExerciseID
        {
            get
            {
                return _ExerciseID;
            }
            set
            {
                OnExerciseIDChanging(value);
                ReportPropertyChanging("ExerciseID");
                _ExerciseID = StructuralObject.SetValidValue(value, "ExerciseID");
                ReportPropertyChanged("ExerciseID");
                OnExerciseIDChanged();
            }
        }
        private global::System.Int32 _ExerciseID;
        partial void OnExerciseIDChanging(global::System.Int32 value);
        partial void OnExerciseIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime SaveDate
        {
            get
            {
                return _SaveDate;
            }
            set
            {
                OnSaveDateChanging(value);
                ReportPropertyChanging("SaveDate");
                _SaveDate = StructuralObject.SetValidValue(value, "SaveDate");
                ReportPropertyChanged("SaveDate");
                OnSaveDateChanged();
            }
        }
        private global::System.DateTime _SaveDate;
        partial void OnSaveDateChanging(global::System.DateTime value);
        partial void OnSaveDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProfileID
        {
            get
            {
                return _ProfileID;
            }
            set
            {
                OnProfileIDChanging(value);
                ReportPropertyChanging("ProfileID");
                _ProfileID = StructuralObject.SetValidValue(value, "ProfileID");
                ReportPropertyChanged("ProfileID");
                OnProfileIDChanged();
            }
        }
        private global::System.Int32 _ProfileID;
        partial void OnProfileIDChanging(global::System.Int32 value);
        partial void OnProfileIDChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToExercises", "tbl_Exercises")]
        public tbl_Exercises tbl_Exercises
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Exercises").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Exercises").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_Exercises> tbl_ExercisesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Exercises");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_Exercises>("ExerciseDatabaseModel.FK_tbl_Workout_ToExercises", "tbl_Exercises", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ExerciseDatabaseModel", "FK_tbl_Workout_ToProfile", "tbl_Profiles")]
        public tbl_Profiles tbl_Profiles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Profiles>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Profiles").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Profiles>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Profiles").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_Profiles> tbl_ProfilesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Profiles>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Profiles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_Profiles>("ExerciseDatabaseModel.FK_tbl_Workout_ToProfile", "tbl_Profiles", value);
                }
            }
        }

        #endregion

    }

    #endregion

}