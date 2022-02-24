import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DirectivesComponent } from './directives/directives.component';
import { EventbindingComponent } from './eventbinding/eventbinding.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import { FormsModule } from '@angular/forms';
import { CrudComponent } from './crud/crud.component';
import { PipesegComponent } from './pipeseg/pipeseg.component';
import { DepartmentFilterPipe } from './departmentfilter';


@NgModule({
  declarations: [
    AppComponent,
    DirectivesComponent,
    EventbindingComponent,
    TwowaybindingComponent,
    CrudComponent,
    PipesegComponent,
    DepartmentFilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [], //service
  bootstrap: [AppComponent]
})
export class AppModule { }
