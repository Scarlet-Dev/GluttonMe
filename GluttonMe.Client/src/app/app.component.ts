import { Component } from '@angular/core';

@Component({
  selector: 'glutton-root',
  template: `
    <router-outlet></router-outlet>
  `,
  styles: []
})
export class AppComponent {
  title = 'GluttonMe';
}
