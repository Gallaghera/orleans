#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Grains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Vylon.Achievement.Grains
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Vylon.Achievement.Grains.UserGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenVylon_Achievement_Grains_UserGrainStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Vylon.Achievement.Grains.UserGrainState).@GetField("<Actions>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Vylon.Achievement.Grains.UserGrainState, global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>> setField0 = (global::System.Action<global::Vylon.Achievement.Grains.UserGrainState, global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = ((global::Vylon.Achievement.Grains.UserGrainState)original);
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Actions));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Vylon.Achievement.Grains.UserGrainState input = (global::Vylon.Achievement.Grains.UserGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Actions, stream, typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Vylon.Achievement.Grains.UserGrainState result = new global::Vylon.Achievement.Grains.UserGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Vylon.Achievement.Interfaces.IActionGrain, global::System.Int32>), stream));
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::HelloWorld.Grains.AchievementGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenHelloWorld_Grains_AchievementGrainStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::HelloWorld.Grains.AchievementGrainState).@GetField("<Created>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::HelloWorld.Grains.AchievementGrainState, global::System.DateTime> setField2 = (global::System.Action<global::HelloWorld.Grains.AchievementGrainState, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::HelloWorld.Grains.AchievementGrainState input = ((global::HelloWorld.Grains.AchievementGrainState)original);
            global::HelloWorld.Grains.AchievementGrainState result = new global::HelloWorld.Grains.AchievementGrainState();
            result.@Action = (global::Vylon.Achievement.Interfaces.IActionGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Action);
            result.@Count = input.@Count;
            setField2(result, input.@Created);
            result.@Description = input.@Description;
            result.@Name = input.@Name;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::HelloWorld.Grains.AchievementGrainState input = (global::HelloWorld.Grains.AchievementGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Action, stream, typeof (global::Vylon.Achievement.Interfaces.IActionGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Count, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Created, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Description, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::HelloWorld.Grains.AchievementGrainState result = new global::HelloWorld.Grains.AchievementGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Action = (global::Vylon.Achievement.Interfaces.IActionGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Vylon.Achievement.Interfaces.IActionGrain), stream);
            result.@Count = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField2(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            result.@Description = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::HelloWorld.Grains.AchievementGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::HelloWorld.Grains.AchievementGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenHelloWorld_Grains_AchievementGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::HelloWorld.Grains.ActionGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenHelloWorld_Grains_ActionGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::HelloWorld.Grains.ActionGrainState input = ((global::HelloWorld.Grains.ActionGrainState)original);
            global::HelloWorld.Grains.ActionGrainState result = new global::HelloWorld.Grains.ActionGrainState();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::HelloWorld.Grains.ActionGrainState input = (global::HelloWorld.Grains.ActionGrainState)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::HelloWorld.Grains.ActionGrainState result = new global::HelloWorld.Grains.ActionGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::HelloWorld.Grains.ActionGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::HelloWorld.Grains.ActionGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenHelloWorld_Grains_ActionGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::HelloWorld.Grains.OrganizationGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenHelloWorld_Grains_OrganizationGrainStateSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::HelloWorld.Grains.OrganizationGrainState).@GetField("<Achievements>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>> setField2 = (global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::HelloWorld.Grains.OrganizationGrainState).@GetField("<Actions>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>> setField1 = (global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::HelloWorld.Grains.OrganizationGrainState).@GetField("<Users>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>> setField0 = (global::System.Action<global::HelloWorld.Grains.OrganizationGrainState, global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::HelloWorld.Grains.OrganizationGrainState input = ((global::HelloWorld.Grains.OrganizationGrainState)original);
            global::HelloWorld.Grains.OrganizationGrainState result = new global::HelloWorld.Grains.OrganizationGrainState();
            setField2(result, (global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Achievements));
            setField1(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Actions));
            setField0(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Users));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::HelloWorld.Grains.OrganizationGrainState input = (global::HelloWorld.Grains.OrganizationGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Achievements, stream, typeof (global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Actions, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Users, stream, typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::HelloWorld.Grains.OrganizationGrainState result = new global::HelloWorld.Grains.OrganizationGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>), stream));
            setField1(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>), stream));
            setField0(result, (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>), stream));
            return (global::HelloWorld.Grains.OrganizationGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::HelloWorld.Grains.OrganizationGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenHelloWorld_Grains_OrganizationGrainStateSerializer()
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
