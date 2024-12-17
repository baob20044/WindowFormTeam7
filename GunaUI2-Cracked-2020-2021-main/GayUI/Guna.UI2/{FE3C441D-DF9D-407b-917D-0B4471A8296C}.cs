using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x0200019D RID: 413
public class {FE3C441D-DF9D-407b-917D-0B4471A8296C}
{
	// Token: 0x06001862 RID: 6242 RVA: 0x000025F1 File Offset: 0x000007F1
	static {FE3C441D-DF9D-407b-917D-0B4471A8296C}()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00006904 File Offset: 0x00004B04
	[Obfuscation]
	public static void dau(int proxyDelegateTypeToken)
	{
		Type typeFromHandle;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle({FE3C441D-DF9D-407b-917D-0B4471A8296C}.moduleHandle_0.ResolveTypeHandle(33554433 + proxyDelegateTypeToken));
		}
		catch
		{
			return;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		int i = 0;
		while (i < fields.Length)
		{
			FieldInfo fieldInfo = fields[i];
			string text = fieldInfo.Name;
			bool flag = false;
			if (text.EndsWith("%"))
			{
				flag = true;
				text = text.TrimEnd(new char[]
				{
					'%'
				});
			}
			byte[] value = Convert.FromBase64String(text);
			uint num = BitConverter.ToUInt32(value, 0);
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle({FE3C441D-DF9D-407b-917D-0B4471A8296C}.moduleHandle_0.ResolveMethodHandle((int)(num + 167772161u)));
			}
			catch
			{
				goto IL_1D7;
			}
			goto IL_AD;
			IL_1D7:
			i++;
			continue;
			IL_AD:
			Delegate value2;
			if (methodInfo.IsStatic)
			{
				try
				{
					value2 = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
					goto IL_1CA;
				}
				catch (Exception)
				{
					goto IL_1D7;
				}
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			int num2 = parameters.Length + 1;
			Type[] array = new Type[num2];
			array[0] = typeof(object);
			for (int j = 1; j < num2; j++)
			{
				array[j] = parameters[j - 1].ParameterType;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			if (num2 > 1)
			{
				ilgenerator.Emit(OpCodes.Ldarg_1);
			}
			if (num2 > 2)
			{
				ilgenerator.Emit(OpCodes.Ldarg_2);
			}
			if (num2 > 3)
			{
				ilgenerator.Emit(OpCodes.Ldarg_3);
			}
			if (num2 > 4)
			{
				for (int k = 4; k < num2; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_S, k);
				}
			}
			ilgenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
			ilgenerator.Emit(OpCodes.Ret);
			try
			{
				value2 = dynamicMethod.CreateDelegate(typeFromHandle);
			}
			catch (Exception)
			{
				goto IL_1D7;
			}
			try
			{
				IL_1CA:
				fieldInfo.SetValue(null, value2);
			}
			catch
			{
			}
			goto IL_1D7;
		}
	}

	// Token: 0x04000AB4 RID: 2740
	private static ModuleHandle moduleHandle_0;

	// Token: 0x04000AB5 RID: 2741
	public static string string_0 = "{FE3C441D-DF9D-407b-917D-0B4471A8296C}";
}
