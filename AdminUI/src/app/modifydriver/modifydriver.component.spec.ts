import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifydriverComponent } from './modifydriver.component';

describe('ModifydriverComponent', () => {
  let component: ModifydriverComponent;
  let fixture: ComponentFixture<ModifydriverComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModifydriverComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ModifydriverComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
