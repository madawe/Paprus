.info
	.source "PapyrusDotNet-Generated.psc"
	.modifyTime 1391435453
	.compileTime 1391435453
	.user "Karlj"
	.computer "CD197"
.endInfo
.userFlagsRef
	.flag conditional 1
	.flag hidden 0
.endUserFlagsRef
.objectTable
	.object DotNetListStack_Bool 
		.userFlags 0
		.docString ""
		.autoState
		.variableTable
			.variable ::Length Int
				.userFlags 0
				.initialValue None
			.endVariable
			.variable ::ItemCount Int
				.userFlags 0
				.initialValue None
			.endVariable
			.variable ::Items DotNetListItem_Bool[]
				.userFlags 0
				.initialValue None
			.endVariable
		.endVariableTable
		.propertyTable
		.endPropertyTable
		.stateTable
			.state
				.function OnInit
					.userFlags 0
					.docString ""
					.return None
					.paramTable
					.endParamTable
					.localTable
					.endLocalTable
					.code
						Assign ::Length None
						Return None
					.endCode
				.endFunction
				.function get_Item
					.userFlags 0
					.docString ""
					.return DotNetListItem_Bool
					.paramTable
						.param index Int
					.endParamTable
					.localTable
						.local V_0 DotNetListItem_Bool
					.endLocalTable
					.code
						ArrayGetElement V_0 ::Items index
						Jump _label12
					_label12:
						Return V_0
					.endCode
				.endFunction
				.function set_Item
					.userFlags 0
					.docString ""
					.return None
					.paramTable
						.param index Int
						.param value DotNetListItem_Bool
					.endParamTable
					.localTable
					.endLocalTable
					.code
						ArraySetElement ::Items index value
						Return None
					.endCode
				.endFunction
			.endState
		.endStateTable
	.endObject
.endObjectTable