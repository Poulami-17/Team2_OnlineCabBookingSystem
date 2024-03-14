import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteroutesComponent } from './deleteroutes.component';

describe('DeleteroutesComponent', () => {
  let component: DeleteroutesComponent;
  let fixture: ComponentFixture<DeleteroutesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DeleteroutesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteroutesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
