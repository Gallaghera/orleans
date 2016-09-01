#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Vylon.Achievement.Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Vylon.Achievement.Interfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Vylon.Achievement.Interfaces.IAchievementGrain))]
    internal class OrleansCodeGenAchievementGrainReference : global::Orleans.Runtime.GrainReference, global::Vylon.Achievement.Interfaces.IAchievementGrain
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
                return 924573768;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Vylon.Achievement.Interfaces.IAchievementGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 924573768;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 924573768:
                    switch (@methodId)
                    {
                        case 1821391414:
                            return "NewAchievement";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 924573768 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @NewAchievement(global::Vylon.Achievement.Interfaces.IAchievement @achievement)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1821391414, new global::System.Object[]{@achievement});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Vylon.Achievement.Interfaces.IAchievementGrain", 924573768, typeof (global::Vylon.Achievement.Interfaces.IAchievementGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
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
                    case 924573768:
                        switch (methodId)
                        {
                            case 1821391414:
                                return ((global::Vylon.Achievement.Interfaces.IAchievementGrain)@grain).@NewAchievement((global::Vylon.Achievement.Interfaces.IAchievement)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 924573768 + ",methodId=" + methodId);
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
                return 924573768;
            }
        }
    }

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
                        case 928434433:
                            return "NewAction";
                        case -779524366:
                            return "GetActionData";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1318300710 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @NewAction(global::Vylon.Achievement.Interfaces.IAction @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(928434433, new global::System.Object[]{@action});
        }

        public global::System.Threading.Tasks.Task<global::Vylon.Achievement.Interfaces.IAction> @GetActionData()
        {
            return base.@InvokeMethodAsync<global::Vylon.Achievement.Interfaces.IAction>(-779524366, null);
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
                            case 928434433:
                                return ((global::Vylon.Achievement.Interfaces.IActionGrain)@grain).@NewAction((global::Vylon.Achievement.Interfaces.IAction)arguments[0]).@Box();
                            case -779524366:
                                return ((global::Vylon.Achievement.Interfaces.IActionGrain)@grain).@GetActionData().@Box();
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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Vylon.Achievement.Interfaces.IGroupGrain))]
    internal class OrleansCodeGenGroupGrainReference : global::Orleans.Runtime.GrainReference, global::Vylon.Achievement.Interfaces.IGroupGrain
    {
        protected @OrleansCodeGenGroupGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenGroupGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 867738520;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Vylon.Achievement.Interfaces.IGroupGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 867738520;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 867738520:
                    switch (@methodId)
                    {
                        case 947476443:
                            return "AddUser";
                        case 679885578:
                            return "NewGroup";
                        case -2111987137:
                            return "NewToken";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 867738520 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @AddUser(global::Vylon.Achievement.Interfaces.IUserGrain @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(947476443, new global::System.Object[]{@user is global::Orleans.Grain ? @user.@AsReference<global::Vylon.Achievement.Interfaces.IUserGrain>() : @user});
        }

        public global::System.Threading.Tasks.Task @NewGroup(global::Vylon.Achievement.Interfaces.IGroup @group, global::Vylon.Achievement.Interfaces.IUser @admin)
        {
            return base.@InvokeMethodAsync<global::System.Object>(679885578, new global::System.Object[]{@group, @admin});
        }

        public global::System.Threading.Tasks.Task<global::System.Guid> @NewToken()
        {
            return base.@InvokeMethodAsync<global::System.Guid>(-2111987137, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Vylon.Achievement.Interfaces.IGroupGrain", 867738520, typeof (global::Vylon.Achievement.Interfaces.IGroupGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenGroupGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                    case 867738520:
                        switch (methodId)
                        {
                            case 947476443:
                                return ((global::Vylon.Achievement.Interfaces.IGroupGrain)@grain).@AddUser((global::Vylon.Achievement.Interfaces.IUserGrain)arguments[0]).@Box();
                            case 679885578:
                                return ((global::Vylon.Achievement.Interfaces.IGroupGrain)@grain).@NewGroup((global::Vylon.Achievement.Interfaces.IGroup)arguments[0], (global::Vylon.Achievement.Interfaces.IUser)arguments[1]).@Box();
                            case -2111987137:
                                return ((global::Vylon.Achievement.Interfaces.IGroupGrain)@grain).@NewToken().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 867738520 + ",methodId=" + methodId);
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
                return 867738520;
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
            return @interfaceId == 1069266804 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1069266804:
                    switch (@methodId)
                    {
                        case 22131610:
                            return "NewUser";
                        case -988336032:
                            return "GetUserData";
                        case 894726647:
                            return "Did";
                        case -1399069882:
                            return "SetGroup";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1069266804 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @NewUser(global::Vylon.Achievement.Interfaces.IUser @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(22131610, new global::System.Object[]{@user});
        }

        public global::System.Threading.Tasks.Task<global::Vylon.Achievement.Interfaces.IUser> @GetUserData()
        {
            return base.@InvokeMethodAsync<global::Vylon.Achievement.Interfaces.IUser>(-988336032, null);
        }

        public global::System.Threading.Tasks.Task @Did(global::Vylon.Achievement.Interfaces.IActionGrain @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(894726647, new global::System.Object[]{@action is global::Orleans.Grain ? @action.@AsReference<global::Vylon.Achievement.Interfaces.IActionGrain>() : @action});
        }

        public global::System.Threading.Tasks.Task @SetGroup(global::Vylon.Achievement.Interfaces.IGroupGrain @group)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1399069882, new global::System.Object[]{@group is global::Orleans.Grain ? @group.@AsReference<global::Vylon.Achievement.Interfaces.IGroupGrain>() : @group});
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
                            case 22131610:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@NewUser((global::Vylon.Achievement.Interfaces.IUser)arguments[0]).@Box();
                            case -988336032:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@GetUserData().@Box();
                            case 894726647:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@Did((global::Vylon.Achievement.Interfaces.IActionGrain)arguments[0]).@Box();
                            case -1399069882:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@SetGroup((global::Vylon.Achievement.Interfaces.IGroupGrain)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1069266804 + ",methodId=" + methodId);
                        }

                    case -1277021679:
                        switch (methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + methodId);
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
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
