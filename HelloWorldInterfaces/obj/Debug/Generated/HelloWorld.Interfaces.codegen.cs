#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("HelloWorld.Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Vylon.Achievement.Interfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Vylon.Achievement.Interfaces.IActionGrain))]
    internal class OrleansCodeGenActionGrainReference : global::Orleans.Runtime.GrainReference, global::Vylon.Achievement.Interfaces.IActionGrain
    {
        protected @OrleansCodeGenActionGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenActionGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1318300710;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Vylon.Achievement.Interfaces.IActionGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1318300710;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1318300710:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1318300710 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Vylon.Achievement.Interfaces.IActionGrain", -1318300710, typeof (global::Vylon.Achievement.Interfaces.IActionGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenActionGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1318300710:
                        switch (methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1318300710 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1318300710;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Vylon.Achievement.Interfaces.IUserGrain))]
    internal class OrleansCodeGenUserGrainReference : global::Orleans.Runtime.GrainReference, global::Vylon.Achievement.Interfaces.IUserGrain
    {
        protected @OrleansCodeGenUserGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenUserGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1069266804;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Vylon.Achievement.Interfaces.IUserGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1069266804;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1069266804:
                    switch (@methodId)
                    {
                        case 894726647:
                            return "Did";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1069266804 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Did(global::Vylon.Achievement.Interfaces.IActionGrain @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(894726647, new global::System.Object[]{@action is global::Orleans.Grain ? @action.@AsReference<global::Vylon.Achievement.Interfaces.IActionGrain>() : @action});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Vylon.Achievement.Interfaces.IUserGrain", 1069266804, typeof (global::Vylon.Achievement.Interfaces.IUserGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenUserGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1069266804:
                        switch (methodId)
                        {
                            case 894726647:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@Did((global::Vylon.Achievement.Interfaces.IActionGrain)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1069266804 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1069266804;
            }
        }
    }
}

namespace HelloWorld.Interfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::HelloWorld.Interfaces.IAchievementGrain))]
    internal class OrleansCodeGenAchievementGrainReference : global::Orleans.Runtime.GrainReference, global::HelloWorld.Interfaces.IAchievementGrain
    {
        protected @OrleansCodeGenAchievementGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenAchievementGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -281523181;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::HelloWorld.Interfaces.IAchievementGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -281523181;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -281523181:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -281523181 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::HelloWorld.Interfaces.IAchievementGrain", -281523181, typeof (global::HelloWorld.Interfaces.IAchievementGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenAchievementGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -281523181:
                        switch (methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -281523181 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -281523181;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::HelloWorld.Interfaces.IOrganizationGrain))]
    internal class OrleansCodeGenOrganizationGrainReference : global::Orleans.Runtime.GrainReference, global::HelloWorld.Interfaces.IOrganizationGrain
    {
        protected @OrleansCodeGenOrganizationGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenOrganizationGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1168191035;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::HelloWorld.Interfaces.IOrganizationGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1168191035;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1168191035:
                    switch (@methodId)
                    {
                        case 947476443:
                            return "AddUser";
                        case 1347849310:
                            return "RemoveUser";
                        case 1055200353:
                            return "ListUsers";
                        case 952351335:
                            return "AddAction";
                        case 1190490817:
                            return "RemoveAction";
                        case 1676135155:
                            return "ListActions";
                        case -1805335989:
                            return "AddAchievement";
                        case 545071652:
                            return "RemoveAchievement";
                        case 1067562934:
                            return "ListAchievements";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1168191035 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @AddUser(global::Vylon.Achievement.Interfaces.IUserGrain @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(947476443, new global::System.Object[]{@user is global::Orleans.Grain ? @user.@AsReference<global::Vylon.Achievement.Interfaces.IUserGrain>() : @user});
        }

        public global::System.Threading.Tasks.Task @RemoveUser(global::Vylon.Achievement.Interfaces.IUserGrain @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1347849310, new global::System.Object[]{@user is global::Orleans.Grain ? @user.@AsReference<global::Vylon.Achievement.Interfaces.IUserGrain>() : @user});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>> @ListUsers()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IUserGrain>>(1055200353, null);
        }

        public global::System.Threading.Tasks.Task @AddAction(global::Vylon.Achievement.Interfaces.IActionGrain @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(952351335, new global::System.Object[]{@action is global::Orleans.Grain ? @action.@AsReference<global::Vylon.Achievement.Interfaces.IActionGrain>() : @action});
        }

        public global::System.Threading.Tasks.Task @RemoveAction(global::Vylon.Achievement.Interfaces.IActionGrain @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1190490817, new global::System.Object[]{@action is global::Orleans.Grain ? @action.@AsReference<global::Vylon.Achievement.Interfaces.IActionGrain>() : @action});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>> @ListActions()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::Vylon.Achievement.Interfaces.IActionGrain>>(1676135155, null);
        }

        public global::System.Threading.Tasks.Task @AddAchievement(global::HelloWorld.Interfaces.IAchievementGrain @achievement)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1805335989, new global::System.Object[]{@achievement is global::Orleans.Grain ? @achievement.@AsReference<global::HelloWorld.Interfaces.IAchievementGrain>() : @achievement});
        }

        public global::System.Threading.Tasks.Task @RemoveAchievement(global::HelloWorld.Interfaces.IAchievementGrain @achievement)
        {
            return base.@InvokeMethodAsync<global::System.Object>(545071652, new global::System.Object[]{@achievement is global::Orleans.Grain ? @achievement.@AsReference<global::HelloWorld.Interfaces.IAchievementGrain>() : @achievement});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>> @ListAchievements()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::HelloWorld.Interfaces.IAchievementGrain>>(1067562934, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::HelloWorld.Interfaces.IOrganizationGrain", 1168191035, typeof (global::HelloWorld.Interfaces.IOrganizationGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenOrganizationGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1168191035:
                        switch (methodId)
                        {
                            case 947476443:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@AddUser((global::Vylon.Achievement.Interfaces.IUserGrain)arguments[0]).@Box();
                            case 1347849310:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@RemoveUser((global::Vylon.Achievement.Interfaces.IUserGrain)arguments[0]).@Box();
                            case 1055200353:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@ListUsers().@Box();
                            case 952351335:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@AddAction((global::Vylon.Achievement.Interfaces.IActionGrain)arguments[0]).@Box();
                            case 1190490817:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@RemoveAction((global::Vylon.Achievement.Interfaces.IActionGrain)arguments[0]).@Box();
                            case 1676135155:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@ListActions().@Box();
                            case -1805335989:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@AddAchievement((global::HelloWorld.Interfaces.IAchievementGrain)arguments[0]).@Box();
                            case 545071652:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@RemoveAchievement((global::HelloWorld.Interfaces.IAchievementGrain)arguments[0]).@Box();
                            case 1067562934:
                                return ((global::HelloWorld.Interfaces.IOrganizationGrain)@grain).@ListAchievements().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1168191035 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1168191035;
            }
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
