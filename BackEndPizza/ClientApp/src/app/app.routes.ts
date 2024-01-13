import { Routes } from '@angular/router';
import { MainComponent } from './Main/Main.component';
import { LoginModule } from './modules/Login/Login.module';
import { LoginComponent } from './modules/Login/Login.component';

export const routes: Routes = [
    { path: '',   component:MainComponent, pathMatch: 'full' },
    { path: 'Login',   component:LoginComponent, pathMatch: 'full' }

];
