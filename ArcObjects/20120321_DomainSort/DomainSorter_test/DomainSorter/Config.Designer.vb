'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5448
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports ESRI.ArcGIS.ArcCatalog
Imports ESRI.ArcGIS.CatalogUI
Imports ESRI.ArcGIS.Desktop.AddIns
Imports ESRI.ArcGIS.Framework
Imports System
Imports System.Collections.Generic

Namespace My
    
    '''<summary>
    '''A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    '''</summary>
    Friend Module ThisAddIn
        
        Friend ReadOnly Property Name() As String
            Get
                Return "DomainSorter"
            End Get
        End Property
        
        Friend ReadOnly Property AddInID() As String
            Get
                Return "{97e04839-2879-48f2-a9a9-5db2cd23f3b2}"
            End Get
        End Property
        
        Friend ReadOnly Property Company() As String
            Get
                Return "ESRI"
            End Get
        End Property
        
        Friend ReadOnly Property Version() As String
            Get
                Return "1.1"
            End Get
        End Property
        
        Friend ReadOnly Property Description() As String
            Get
                Return "This is an upgrade of ESRI's Domain Sort from VB6 to ArcObjects.Net (10.0).  "&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Up"& _ 
                    "grade done by Matthew Rantala"&Global.Microsoft.VisualBasic.ChrW(10)&"http://nodedangles.wordpress.com/"&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Original Code d"& _ 
                    "ownloaded from:"&Global.Microsoft.VisualBasic.ChrW(10)&"http://resources.esri.com/help/9.3/ArcGISDesktop/com/samples/geo"& _ 
                    "database/Schema_Creation_and_Management/sort_a_domain/e826c5a8-9740-4f0b-86b6-d3"& _ 
                    "b834735574.htm&lt;/Description&gt;"&Global.Microsoft.VisualBasic.ChrW(10)
            End Get
        End Property
        
        Friend ReadOnly Property Author() As String
            Get
                Return "ESRI (Upgrade by Rantala)"
            End Get
        End Property
        
        Friend ReadOnly Property [Date]() As String
            Get
                Return "3/21/2012"
            End Get
        End Property
        
        '''<summary>
        '''A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        '''</summary>
        Friend Class IDs
            
            '''<summary>
            '''Returns 'ESRI_DomainSorter_btnDomainSorter', the id declared for Add-in Button class 'btnDomainSorter'
            '''</summary>
            Friend Shared ReadOnly Property btnDomainSorter() As String
                Get
                    Return "ESRI_DomainSorter_btnDomainSorter"
                End Get
            End Property
        End Class
    End Module
    
Friend Module ArcCatalog
  Private s_app As ESRI.ArcGIS.Framework.IApplication
  Private s_docEvent As ESRI.ArcGIS.ArcCatalog.IGxDocumentEvents_Event

  Public ReadOnly Property Application() As ESRI.ArcGIS.Framework.IApplication
    Get
      If s_app Is Nothing Then
        s_app = TryCast(Internal.AddInStartupObject.GetHook(Of ESRI.ArcGIS.CatalogUI.IGxApplication)(), ESRI.ArcGIS.Framework.IApplication)
      End If

      Return s_app
    End Get
  End Property

  Public ReadOnly Property Document() As ESRI.ArcGIS.Framework.IDocument
    Get
      If Application IsNot Nothing Then
        Return Application.Document
      End If

      Return Nothing
    End Get
  End Property
  Public ReadOnly Property ThisApplication() As ESRI.ArcGIS.CatalogUI.IGxApplication
    Get
      Return TryCast(Application, ESRI.ArcGIS.CatalogUI.IGxApplication)
    End Get
  End Property
  Public ReadOnly Property DockableWindowManager() As ESRI.ArcGIS.Framework.IDockableWindowManager
    Get
      Return TryCast(Application, ESRI.ArcGIS.Framework.IDockableWindowManager)
    End Get
  End Property

  Public ReadOnly Property Events() As ESRI.ArcGIS.ArcCatalog.IGxDocumentEvents_Event
    Get
      s_docEvent = TryCast(Document, ESRI.ArcGIS.ArcCatalog.IGxDocumentEvents_Event)
      Return s_docEvent
    End Get
  End Property
End Module

Namespace Internal
  <ESRI.ArcGIS.Desktop.AddIns.StartupObjectAttribute(), _
   Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
   Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
  Partial Public Class AddInStartupObject
    Inherits ESRI.ArcGIS.Desktop.AddIns.AddInEntryPoint

    Private m_addinHooks As List(Of Object)
    Private Shared _sAddInHostManager As AddInStartupObject

    Public Sub New()

    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Function Initialize(ByVal hook As Object) As Boolean
      Dim createSingleton As Boolean = _sAddInHostManager Is Nothing
      If createSingleton Then
        _sAddInHostManager = Me
        m_addinHooks = New List(Of Object)
        m_addinHooks.Add(hook)
      ElseIf Not _sAddInHostManager.m_addinHooks.Contains(hook) Then
        _sAddInHostManager.m_addinHooks.Add(hook)
      End If

      Return createSingleton
    End Function

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Sub Shutdown()
      _sAddInHostManager = Nothing
      m_addinHooks = Nothing
    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared Function GetHook(Of T As Class)() As T
      If _sAddInHostManager IsNot Nothing Then
        For Each o As Object In _sAddInHostManager.m_addinHooks
          If TypeOf o Is T Then
            Return DirectCast(o, T)
          End If
        Next
      End If

      Return Nothing
    End Function

    ''' <summary>
    ''' Expose this instance of Add-in class externally
    ''' </summary>
    Public Shared Function GetThis() As AddInStartupObject
      Return _sAddInHostManager
    End Function

  End Class
End Namespace

End Namespace
