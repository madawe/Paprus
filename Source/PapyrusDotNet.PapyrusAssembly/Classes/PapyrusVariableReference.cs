//     This file is part of PapyrusDotNet.
// 
//     PapyrusDotNet is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     PapyrusDotNet is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
//  
//     Copyright 2015, Karl Patrik Johansson, zerratar@gmail.com

#region



#endregion

namespace PapyrusDotNet.PapyrusAssembly
{
    public class PapyrusVariableReference
    {
        public PapyrusStringRef Name { get; set; }
        public PapyrusStringRef TypeName { get; set; }
        public object Value { get; set; }
        public PapyrusPrimitiveType ValueType { get; set; }
        public bool IsDelegateReference { get; set; }
        public string DelegateInvokeReference { get; set; }

        public PapyrusVariableReference()
        {
        }

        public PapyrusVariableReference(PapyrusStringRef name, PapyrusPrimitiveType type)
        {
            ValueType = type;
            Name = name;
        }

        public PapyrusVariableReference(PapyrusStringRef name, PapyrusStringRef variableTypeName)
        {
            Name = name;
            TypeName = variableTypeName;
        }
    }
}