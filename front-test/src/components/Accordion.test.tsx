import { describe, expect, test } from "vitest";
import Accordion from "./Accordion";
import {render, screen} from '@testing-library/react'

describe("Accordion", () => {
    test("Should render component", () => {
        render(<Accordion title="test">
            <h3>Test Content</h3>
        </Accordion>)    
        expect(screen.getByText("test")).toBeDefined()
    })
})