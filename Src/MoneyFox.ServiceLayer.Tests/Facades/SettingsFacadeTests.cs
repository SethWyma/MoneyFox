﻿using System;
using System.Diagnostics.CodeAnalysis;
using MoneyFox.BusinessLogic.Adapters;
using MoneyFox.Foundation;
using MoneyFox.ServiceLayer.Facades;
using Moq;
using Should;
using Xunit;

namespace MoneyFox.ServiceLayer.Tests.Facades
{
    [ExcludeFromCodeCoverage]
    public class SettingsFacadeTests {
        private ISettingsAdapter settingsAdapter;

        public SettingsFacadeTests() {
            var settingsAdapterMock = new Mock<ISettingsAdapter>();
            settingsAdapterMock.Setup(x => x.GetValue(It.IsAny<string>(), It.IsAny<string>()))
                               .Returns((string key, string defaultValue) => defaultValue);
            settingsAdapterMock.Setup(x => x.GetValue(It.IsAny<string>(), It.IsAny<int>()))
                               .Returns((string key, int defaultValue) => defaultValue);
            settingsAdapterMock.Setup(x => x.GetValue(It.IsAny<string>(), It.IsAny<bool>()))
                               .Returns((string key, bool defaultValue) => defaultValue);

            settingsAdapter = settingsAdapterMock.Object;
        }

        [Fact]
        public void Ctor_DefaultValues_IsBackupAutouploadEnabledFalse()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.IsBackupAutouploadEnabled.ShouldBeFalse();
        }

        [Fact]
        public void Ctor_DefaultValues_SessionTimestampEmpty()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.SessionTimestamp.ShouldBeEmpty();
        }

        [Fact]
        public void Ctor_DefaultValues_PasswordRequiredFalse()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.PasswordRequired.ShouldBeFalse();
        }

        [Fact]
        public void Ctor_DefaultValues_LastDatabaseUpdateMinDate()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.LastDatabaseUpdate.ShouldEqual(DateTime.MinValue);
        }

        [Fact]
        public void Ctor_DefaultValues_ThemeLight()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.Theme.ShouldEqual(AppTheme.Light);
        }

        [Fact]
        public void Ctor_DefaultValues_IsLoggedInToBackupServiceFalse()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.IsLoggedInToBackupService.ShouldBeFalse();
        }

        [Fact]
        public void Ctor_DefaultValues_BackupSyncRecurrenceThreeHours()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.BackupSyncRecurrence.ShouldEqual(3);
        }

        [Fact]
        public void Ctor_DefaultValues_LastExecutionTimeStampSyncBackupMinDate()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.LastExecutionTimeStampSyncBackup.ShouldEqual(DateTime.MinValue);
        }

        [Fact]
        public void Ctor_DefaultValues_LastExecutionTimeStampClearPaymentsMinDate()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.LastExecutionTimeStampClearPayments.ShouldEqual(DateTime.MinValue);
        }

        [Fact]
        public void Ctor_DefaultValues_LastExecutionTimeStampRecurringPaymentsMinDate()
        {
            // Arrange
            
            // Act
            var settingsfacade = new SettingsFacade(settingsAdapter);

            // Assert
            settingsfacade.LastExecutionTimeStampRecurringPayments.ShouldEqual(DateTime.MinValue);
        }
    }
}