#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Vylon.Achievement.Grains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Vylon.Achievement.Grains
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.AchievementGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_AchievementGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.AchievementGrainState input = ((global::Vylon.Achievement.Grains.AchievementGrainState)original);
            global::Vylon.Achievement.Grains.AchievementGrainState result = new global::Vylon.Achievement.Grains.AchievementGrainState();
            result.@Action = (global::Vylon.Achievement.Interfaces.IActionGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Action);
            result.@Count = input.@Count;
            result.@Description = input.@Description;
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Id);
            result.@Name = input.@Name;
            result.@Type = input.@Type;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.AchievementGrainState input = (global::Vylon.Achievement.Grains.AchievementGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Action, stream, typeof (global::Vylon.Achievement.Interfaces.IActionGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Count, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Description, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Type, stream, typeof (global::Vylon.Achievement.Interfaces.AchievementType));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.AchievementGrainState result = new global::Vylon.Achievement.Grains.AchievementGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Action = (global::Vylon.Achievement.Interfaces.IActionGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.IActionGrain), stream);
            result.@Count = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Description = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Type = (global::Vylon.Achievement.Interfaces.AchievementType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.AchievementType), stream);
            return (global::Vylon.Achievement.Grains.AchievementGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Vylon.Achievement.Grains.AchievementGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenVylon_Achievement_Grains_AchievementGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.ActionGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_ActionGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.ActionGrainState input = ((global::Vylon.Achievement.Grains.ActionGrainState)original);
            global::Vylon.Achievement.Grains.ActionGrainState result = new global::Vylon.Achievement.Grains.ActionGrainState();
            result.@Description = input.@Description;
            result.@Name = input.@Name;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.ActionGrainState input = (global::Vylon.Achievement.Grains.ActionGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Description, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.ActionGrainState result = new global::Vylon.Achievement.Grains.ActionGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Description = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::Vylon.Achievement.Grains.ActionGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Vylon.Achievement.Grains.ActionGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenVylon_Achievement_Grains_ActionGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.GroupGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_GroupGrainStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Achievements>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>> setField6 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Actions>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>> setField5 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Users>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>> setField4 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.GroupGrainState input = ((global::Vylon.Achievement.Grains.GroupGrainState)original);
            global::Vylon.Achievement.Grains.GroupGrainState result = new global::Vylon.Achievement.Grains.GroupGrainState();
            setField6(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Achievements));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Actions));
            result.@Admin = (global::Vylon.Achievement.Interfaces.IUserGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Admin);
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Id);
            result.@Name = input.@Name;
            result.@Token = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token);
            setField4(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Users));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.GroupGrainState input = (global::Vylon.Achievement.Grains.GroupGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Achievements, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Actions, stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Admin, stream, typeof (global::Vylon.Achievement.Interfaces.IUserGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Users, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.GroupGrainState result = new global::Vylon.Achievement.Grains.GroupGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField6(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>), stream));
            setField5(result, (global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::Vylon.Achievement.Interfaces.IActionGrain>), stream));
            result.@Admin = (global::Vylon.Achievement.Interfaces.IUserGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.IUserGrain), stream);
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Token = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            setField4(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>), stream));
            return (global::Vylon.Achievement.Grains.GroupGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Vylon.Achievement.Grains.GroupGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenVylon_Achievement_Grains_GroupGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.UserGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_UserGrainStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Vylon.Achievement.Grains.UserGrainState).@GetField("<Stats>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.UserGrainState, global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>> setField5 = (global::System.Action<global::Vylon.Achievement.Grains.UserGrainState, global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = ((global::Vylon.Achievement.Grains.UserGrainState)original);
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            result.@Email = input.@Email;
            result.@FirstName = input.@FirstName;
            result.@Group = (global::Vylon.Achievement.Interfaces.IGroupGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Group);
            result.@LastName = input.@LastName;
            result.@Password = input.@Password;
            setField5(result, (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Stats));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = (global::Vylon.Achievement.Grains.UserGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Email, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FirstName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Group, stream, typeof (global::Vylon.Achievement.Interfaces.IGroupGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Password, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Stats, stream, typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Email = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@FirstName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Group = (global::Vylon.Achievement.Interfaces.IGroupGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.IGroupGrain), stream);
            result.@LastName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Password = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            setField5(result, (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>), stream));
            return (global::Vylon.Achievement.Grains.UserGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Vylon.Achievement.Grains.UserGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenVylon_Achievement_Grains_UserGrainStateSerializer()
        {
            Register();
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
