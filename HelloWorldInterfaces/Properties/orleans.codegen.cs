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

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Vylon.Achievement.Interfaces.IAccountGrain))]
    internal class OrleansCodeGenAccountGrainReference : global::Orleans.Runtime.GrainReference, global::Vylon.Achievement.Interfaces.IAccountGrain
    {
        protected @OrleansCodeGenAccountGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenAccountGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1169694206;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Vylon.Achievement.Interfaces.IAccountGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1169694206;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1169694206:
                    switch (@methodId)
                    {
                        case 325186730:
                            return "New";
                        case 789847551:
                            return "AddUser";
                        case -639237804:
                            return "AddAction";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1169694206 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @New(global::Vylon.Achievement.Interfaces.IAccount @account)
        {
            return base.@InvokeMethodAsync<global::System.Object>(325186730, new global::System.Object[]{@account});
        }

        public global::System.Threading.Tasks.Task @AddUser(global::Vylon.Achievement.Interfaces.IUser @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(789847551, new global::System.Object[]{@user});
        }

        public global::System.Threading.Tasks.Task @AddAction(global::Vylon.Achievement.Interfaces.IAction @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-639237804, new global::System.Object[]{@action});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.3.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Vylon.Achievement.Interfaces.IAccountGrain", -1169694206, typeof (global::Vylon.Achievement.Interfaces.IAccountGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenAccountGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
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
                    case -1169694206:
                        switch (methodId)
                        {
                            case 325186730:
                                return ((global::Vylon.Achievement.Interfaces.IAccountGrain)@grain).@New((global::Vylon.Achievement.Interfaces.IAccount)arguments[0]).@Box();
                            case 789847551:
                                return ((global::Vylon.Achievement.Interfaces.IAccountGrain)@grain).@AddUser((global::Vylon.Achievement.Interfaces.IUser)arguments[0]).@Box();
                            case -639237804:
                                return ((global::Vylon.Achievement.Interfaces.IAccountGrain)@grain).@AddAction((global::Vylon.Achievement.Interfaces.IAction)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1169694206 + ",methodId=" + methodId);
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
                return -1169694206;
            }
        }
    }

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
                        case 538143103:
                            return "New";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 924573768 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @New(global::Vylon.Achievement.Interfaces.IAchievement @achievement)
        {
            return base.@InvokeMethodAsync<global::System.Object>(538143103, new global::System.Object[]{@achievement});
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
                            case 538143103:
                                return ((global::Vylon.Achievement.Interfaces.IAchievementGrain)@grain).@New((global::Vylon.Achievement.Interfaces.IAchievement)arguments[0]).@Box();
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
                        case 427203287:
                            return "New";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1318300710 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @New(global::Vylon.Achievement.Interfaces.IAction @action)
        {
            return base.@InvokeMethodAsync<global::System.Object>(427203287, new global::System.Object[]{@action});
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
                            case 427203287:
                                return ((global::Vylon.Achievement.Interfaces.IActionGrain)@grain).@New((global::Vylon.Achievement.Interfaces.IAction)arguments[0]).@Box();
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
                        case -151380608:
                            return "New";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 867738520 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @New(global::Vylon.Achievement.Interfaces.IGroup @group)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-151380608, new global::System.Object[]{@group});
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
                            case -151380608:
                                return ((global::Vylon.Achievement.Interfaces.IGroupGrain)@grain).@New((global::Vylon.Achievement.Interfaces.IGroup)arguments[0]).@Box();
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
                        case -427426798:
                            return "New";
                        case 1957669126:
                            return "Exists";
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

        public global::System.Threading.Tasks.Task @New(global::Vylon.Achievement.Interfaces.IUser @user)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-427426798, new global::System.Object[]{@user});
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @Exists()
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(1957669126, null);
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
                            case -427426798:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@New((global::Vylon.Achievement.Interfaces.IUser)arguments[0]).@Box();
                            case 1957669126:
                                return ((global::Vylon.Achievement.Interfaces.IUserGrain)@grain).@Exists().@Box();
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
