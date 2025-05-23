﻿using Potisan.Windows.Diagnostics.Wua.ComTypes;

namespace Potisan.Windows.Diagnostics.Wua;

public sealed class WuaInstallationProgressChangedCallbackArgs(object? o) : ComUnknownWrapperBase<IInstallationProgressChangedCallbackArgs>(o)
{
	public ComDispatch? AsDispatch => this.As<ComDispatch, IDispatch>();

	public ComResult<WuaDownloadProgress> ProgressNoThrow
		=> new(_obj.get_Progress(out var x), new(x));

	public WuaDownloadProgress Progress
		=> ProgressNoThrow.Value;
}
