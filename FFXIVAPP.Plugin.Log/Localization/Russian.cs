﻿// FFXIVAPP.Plugin.Log
// Russian.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution. 
//  * Neither the name of SyndicatedLife nor the names of its contributors may 
//    be used to endorse or promote products derived from this software 
//    without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE. 

using System.Windows;

namespace FFXIVAPP.Plugin.Log.Localization
{
    public abstract class Russian
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("log_", "*PH*");
            Dictionary.Add("log_AddTabButtonText", "Добавить Вкладку");
            Dictionary.Add("log_AllTabHeader", "Все");
            Dictionary.Add("log_DebugTabHeader", "Отладка");
            Dictionary.Add("log_DebugOptionsHeader", "Опции Отладки");
            Dictionary.Add("log_EnableDebugHeader", "Включить Отладку");
            Dictionary.Add("log_EnableTranslateHeader", "Включить Перевод");
            Dictionary.Add("log_RegExLabel", "RegEx:");
            Dictionary.Add("log_UseRomanizationHeader", "Использовать Романизацию");
            Dictionary.Add("log_ShowASCIIDebugHeader", "Показать ASCII Отладку");
            Dictionary.Add("log_TabNameLabel", "Имя Вкладки:");
            Dictionary.Add("log_TranslateLSHeader", "LS");
            Dictionary.Add("log_TranslateFCHeader", "FC");
            Dictionary.Add("log_TranslatePartyHeader", "Party");
            Dictionary.Add("log_TranslateableChatTabHeader", "Чат с переводом");
            Dictionary.Add("log_TranslatedTabHeader", "Перевод");
            Dictionary.Add("log_TranslateJPOnlyHeader", "Переводить только Японский");
            Dictionary.Add("log_TranslateSettingsTabHeader", "Настройки Перевода");
            Dictionary.Add("log_TranslateToHeader", "Перевести на");
            Dictionary.Add("log_TranslateSayHeader", "Say");
            Dictionary.Add("log_TranslateShoutHeader", "Shout");
            Dictionary.Add("log_TranslateTellHeader", "Tell");
            Dictionary.Add("log_TranslateYellHeader", "Yell");
            Dictionary.Add("log_EnableAllHeader", "Включить все");
            Dictionary.Add("log_TranslateAllianceHeader", "Alliance");
            Dictionary.Add("log_GitHubButtonText", "Страница проекта (GitHub)");
            return Dictionary;
        }
    }
}