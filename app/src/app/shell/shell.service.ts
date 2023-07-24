import { Route, Routes } from '@angular/router';
import { ShellComponent } from './shell.component';

export class Shell {
  static childRoutes(shellRoutes: Routes): Route {
    return { path: '', component: ShellComponent, children: shellRoutes };
  }
}
