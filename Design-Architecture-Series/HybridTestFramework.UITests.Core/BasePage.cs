﻿// <copyright file="BasePage.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using HybridTestFramework.UITests.Core;

namespace HybridTestFramework.UITests.Core
{
    public abstract class BasePage
    {
        private readonly IElementFinder elementFinder;
        private readonly INavigationService navigationService;

        public BasePage(IElementFinder elementFinder, INavigationService navigationService)
        {
            this.elementFinder = elementFinder;
            this.navigationService = navigationService;
        }

        protected IElementFinder ElementFinder
        {
            get
            {
                return this.elementFinder;
            }
        }

        protected INavigationService NavigationService
        {
            get
            {
                return this.navigationService;
            }
        }
    }
}