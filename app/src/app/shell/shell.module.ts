import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ShellComponent } from './shell.component';
import { HeaderComponent } from './components/header/header.component';

@NgModule({
  declarations: [ShellComponent, HeaderComponent],
  imports: [CommonModule, RouterModule],
  exports: [ShellComponent],
})
export class ShellModule {}
