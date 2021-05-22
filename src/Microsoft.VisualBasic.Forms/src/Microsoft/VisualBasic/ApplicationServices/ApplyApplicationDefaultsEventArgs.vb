﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Option Strict On
Option Explicit On
Option Infer On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.Application

Namespace Microsoft.VisualBasic.ApplicationServices

    ''' <summary>
    ''' Provides context for the Startup event.
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Advanced), ComVisible(False)>
    Public Class ApplyApplicationDefaultsEventArgs
        Inherits EventArgs

        ''' <summary>
        ''' Creates a new instance of the StartupEventArgs.
        ''' </summary>
        Public Sub New(applicationDefaults As ApplicationDefaults)
            _ApplicationDefaults = applicationDefaults
        End Sub

        ''' <summary>
        ''' Gets or Sets the HighDpiMode.
        ''' </summary>
        Public ReadOnly Property ApplicationDefaults As ApplicationDefaults
    End Class
End Namespace
