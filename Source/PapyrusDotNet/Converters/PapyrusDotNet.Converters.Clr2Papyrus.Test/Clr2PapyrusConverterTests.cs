﻿//     This file is part of PapyrusDotNet.
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
//     Copyright 2016, Karl Patrik Johansson, zerratar@gmail.com

#region

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using PapyrusDotNet.Common.Utilities;
using PapyrusDotNet.Converters.Clr2Papyrus.Enums;
using PapyrusDotNet.Converters.Clr2Papyrus.Implementations;
using PapyrusDotNet.Converters.Clr2Papyrus.Implementations.Processors;
using PapyrusDotNet.PapyrusAssembly;

#endregion

namespace PapyrusDotNet.Converters.Clr2Papyrus.Test
{
    [TestClass]
    public class PapyrusMethodFlagsTests
    {
        [TestMethod]
        public void TestPapyrusMethodFlags()
        {
            var m = new PapyrusMethodDefinition(PapyrusAssemblyDefinition.CreateAssembly(PapyrusVersionTargets.Fallout4));
            m.SetFlags(PapyrusMethodFlags.Global);
            Assert.IsTrue(m.IsGlobal);
            Assert.IsFalse(m.IsNative);

            m.IsNative = true;
            Assert.IsTrue(m.IsGlobal);
            Assert.IsTrue(m.IsNative);


            m.IsGlobal = false;
            Assert.IsFalse(m.IsGlobal);
            Assert.IsTrue(m.IsNative);
        }
    }

    [TestClass]
    public class Clr2PapyrusConverterTests
    {
        [TestMethod]
        public void Clr2PapyrusConverter_Convert()
        {
            var papyrusCompiler = new Clr2PapyrusConverter(new NoopUserInterface(), new ClrInstructionProcessor(
                    new LoadProcessor(),
                    new StoreProcessor(new PapyrusValueTypeConverter()),
                    new BranchProcessor(),
                    new CallProcessor(new PapyrusValueTypeConverter()),
                    new ConditionalProcessor(),
                    new ReturnProcessor(new PapyrusValueTypeConverter()),
                    new StringConcatProcessor()
                ),
                PapyrusCompilerOptions.Strict);
            var value = papyrusCompiler.Convert(new ClrAssemblyInput(
                AssemblyDefinition.ReadAssembly(
                    @"D:\Git\PapyrusDotNet\Examples\Fallout4Example\bin\Debug\Fallout4Example.dll"),
                PapyrusVersionTargets.Fallout4));

            var papyrusOutput = value as PapyrusAssemblyOutput;

            Assert.IsNotNull(papyrusOutput);
            var assemblies = papyrusOutput.Assemblies;
            Assert.IsNotNull(assemblies);
            Assert.IsTrue(assemblies.Length > 0);
        }
    }
}