Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Namespace WpfApplication26

	Public Class Category
		Private name_Renamed As String
		Private products_Renamed As List(Of Product)
		Public Sub New(ByVal name As String)
			Me.name_Renamed = name
			products_Renamed = New List(Of Product)()
		End Sub
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Public ReadOnly Property Products() As List(Of Product)
			Get
				Return products_Renamed
			End Get
		End Property
	End Class
	Public Class Product
		Private name_Renamed As String
		Private price_Renamed As Double
		Public Sub New(ByVal name As String, ByVal price As Double)
			Me.name_Renamed = name
			Me.price_Renamed = price
		End Sub
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Public Property Price() As Double
			Get
				Return price_Renamed
			End Get
			Set(ByVal value As Double)
				price_Renamed = value
			End Set
		End Property
	End Class

	Public Class DataSource
		Private categories_Renamed As List(Of Category)
		Public Sub New()
			categories_Renamed = New List(Of Category)()
			categories_Renamed.Add(New Category("First"))
			categories_Renamed(0).Products.Add(New Product("Product 1.1", 10))
			categories_Renamed(0).Products.Add(New Product("Product 1.2", 20))
			categories_Renamed(0).Products.Add(New Product("Product 1.3", 30))
			categories_Renamed(0).Products.Add(New Product("Product 1.4", 40))
			categories_Renamed.Add(New Category("Second"))
			categories_Renamed(1).Products.Add(New Product("Product 2.1", 10))
			categories_Renamed(1).Products.Add(New Product("Product 2.2", 20))
			categories_Renamed.Add(New Category("Third"))
			categories_Renamed(2).Products.Add(New Product("Product 3.1", 10))
			categories_Renamed(2).Products.Add(New Product("Product 3.2", 20))
			categories_Renamed(2).Products.Add(New Product("Product 3.4", 40))
			categories_Renamed.Add(New Category("Fourth"))
			categories_Renamed(3).Products.Add(New Product("Product 4.1", 10))
			categories_Renamed(3).Products.Add(New Product("Product 4.2", 20))
			categories_Renamed(3).Products.Add(New Product("Product 4.3", 30))
			categories_Renamed(3).Products.Add(New Product("Product 4.4", 40))
		End Sub
		Public ReadOnly Property Categories() As List(Of Category)
			Get
				Return categories_Renamed
			End Get
		End Property
	End Class
End Namespace