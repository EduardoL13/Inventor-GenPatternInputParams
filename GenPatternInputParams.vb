	Sub Main ()
		
		Dim esteDoc As AssemblyDocument = ThisDoc.Document
		Dim partDef As AssemblyComponentDefinition = esteDoc.ComponentDefinition
		
		Dim designTrackPropSet As PropertySet = esteDoc.PropertySets.Item("Design Tracking Properties")
		Dim descProp As Object = designTrackPropSet.Item("Description")
		
		sufix = InputBox("Enter Pattern feature name", "Pattern Feature Name", "ej:Face1holes")
		
		descProp.Expression = sufix
		
		Dim spacingValue As String = "spacingValue"
		partDef.Parameters.UserParameters.AddByValue(spacingValue & sufix, 1, "in")
		
		Dim lengthPattern As String = "lengthPattern"
		partDef.Parameters.UserParameters.AddByValue(lengthPattern & sufix, 1, "in")
		
	End Sub
