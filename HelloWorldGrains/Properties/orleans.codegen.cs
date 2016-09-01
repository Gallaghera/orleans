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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.AccountGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_AccountGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.AccountGrainState input = ((global::Vylon.Achievement.Grains.AccountGrainState)original);
            global::Vylon.Achievement.Grains.AccountGrainState result = new global::Vylon.Achievement.Grains.AccountGrainState();
            result.@Actions = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Actions);
            result.@Admin = (global::Vylon.Achievement.Interfaces.IUserGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Admin);
            result.@Created = input.@Created;
            result.@Groups = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IGroupGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Groups);
            result.@Name = input.@Name;
            result.@Status = input.@Status;
            result.@Token = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Token);
            result.@Users = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Users);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.AccountGrainState input = (global::Vylon.Achievement.Grains.AccountGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Actions, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Admin, stream, typeof (global::Vylon.Achievement.Interfaces.IUserGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Created, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Groups, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IGroupGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::Vylon.Achievement.Interfaces.AccountStatus));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Token, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Users, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.AccountGrainState result = new global::Vylon.Achievement.Grains.AccountGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Actions = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>), stream);
            result.@Admin = (global::Vylon.Achievement.Interfaces.IUserGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.IUserGrain), stream);
            result.@Created = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Groups = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IGroupGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IGroupGrain>), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Status = (global::Vylon.Achievement.Interfaces.AccountStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.AccountStatus), stream);
            result.@Token = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@Users = (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>), stream);
            return (global::Vylon.Achievement.Grains.AccountGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Vylon.Achievement.Grains.AccountGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenVylon_Achievement_Grains_AccountGrainStateSerializer()
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
            result.@Created = input.@Created;
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Id);
            result.@Name = input.@Name;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.ActionGrainState input = (global::Vylon.Achievement.Grains.ActionGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Created, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.ActionGrainState result = new global::Vylon.Achievement.Grains.ActionGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Created = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Id = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
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
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Achievements>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>> setField2 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Actions>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>> setField1 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Vylon.Achievement.Grains.GroupGrainState).@GetField("<Users>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>> setField0 = (global::System.Action<global::Vylon.Achievement.Grains.GroupGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.GroupGrainState input = ((global::Vylon.Achievement.Grains.GroupGrainState)original);
            global::Vylon.Achievement.Grains.GroupGrainState result = new global::Vylon.Achievement.Grains.GroupGrainState();
            setField2(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Achievements));
            setField1(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Actions));
            setField0(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Users));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.GroupGrainState input = (global::Vylon.Achievement.Grains.GroupGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Achievements, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Actions, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Users, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.GroupGrainState result = new global::Vylon.Achievement.Grains.GroupGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IAchievementGrain>), stream));
            setField1(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>), stream));
            setField0(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>), stream));
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
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = ((global::Vylon.Achievement.Grains.UserGrainState)original);
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            result.@Created = input.@Created;
            result.@Email = input.@Email;
            result.@FirstName = input.@FirstName;
            result.@LastName = input.@LastName;
            result.@Stats = (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Stats);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = (global::Vylon.Achievement.Grains.UserGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Created, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Email, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FirstName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Stats, stream, typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Created = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Email = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@FirstName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@LastName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Stats = (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>), stream);
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
