import { Optional, SkipSelf, NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './services/auth.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { NotificationService } from './services/notification.service';
import { LocalStorageService } from './services/local-storage.service';
import { CurrencyNotificationService } from '@ecommerce/services/currency-notification.service';
import { ConfirmationDialogService } from './services/confirmation-dialog.service';
import { SignalrService } from './services/signalr.service';

@NgModule({
  declarations: [],
  imports: [
    HttpClientModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added,
  ],
  providers: [
    AuthService,
    //TODO: maybe we should consider lazyloaded animation until needed for better perf using the new API: provideAnimationsAsync()
    BrowserAnimationsModule,
    ToastrModule,
    NotificationService,
    ConfirmationDialogService,
    LocalStorageService,
    CurrencyNotificationService,
    SignalrService,
  ],
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() core: CoreModule) {
    if (core) {
      throw new Error('You should import core module only in the root module');
    }
  }
}
