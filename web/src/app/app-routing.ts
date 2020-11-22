import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { ProfessionalComponent } from './professional/professional.component';
import { ScheduleComponent } from './schedule/schedule.component';


const routes: Routes = [
    {path: '', component: HomeComponent},  
    {path: 'professional', component: ProfessionalComponent},
    {path: 'professional/schedule/:id', component: ScheduleComponent}
  ];

export const AppRoutes: ModuleWithProviders = RouterModule.forRoot(routes);